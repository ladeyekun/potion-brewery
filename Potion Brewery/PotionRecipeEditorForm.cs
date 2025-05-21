using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PotionBrewery.BLL;
using PotionBrewery.Models;

namespace Potion_Brewery {
    public partial class PotionRecipeEditorForm : Form {
        private readonly IngredientService _ingredientService;
        private readonly PotionRecipeService _recipeService;
        private readonly List<RecipeIngredient> _selectedIngredients = new();
        private PotionRecipe _existing = null;

        public PotionRecipeEditorForm(IngredientService ingredientService, PotionRecipeService potionRecipeService, PotionRecipe existing = null) {
            InitializeComponent();
            _ingredientService = ingredientService;
            _recipeService = potionRecipeService;
            _existing = existing;
        }

        private async void PotionRecipeEditorForm_Load(object sender, EventArgs e) {
            var ingredients = await _ingredientService.GetIngredients();
            IngredientCombo.DataSource = ingredients;
            IngredientCombo.DisplayMember = "Name";
            IngredientCombo.ValueMember = "IngredientId";
            LoadRecipe(_existing);
        }

        private void AddIngredientBtn_Click(object sender, EventArgs e) {
            if (IngredientCombo.SelectedItem is Ingredient selected && IngredientQnty.Value > 0) {
                var existing = _selectedIngredients.FirstOrDefault(i => i.IngredientId == selected.IngredientId);
                if (existing == null) {
                    _selectedIngredients.Add(new RecipeIngredient {
                        IngredientId = selected.IngredientId,
                        Ingredient = selected,
                        QuantityRequired = (int)IngredientQnty.Value
                    });
                    dataGridView1.Rows.Add(selected.Name, IngredientQnty.Value);
                }
                else {
                    MessageBox.Show("Ingredient already added");
                }
            }
        }

        private async void SaveRecipeBtn_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(RecipeName.Text)) {
                MessageBox.Show("Please enter a potion name.");
                return;
            }

            if (_selectedIngredients.Count == 0) {
                MessageBox.Show("Please add at least one ingredient.");
                return;
            }

            try {
                if (_existing == null) {
                    PotionRecipe recipe = new PotionRecipe {
                        Name = RecipeName.Text.Trim(),
                        Description = RecipeDescription.Text.Trim(),
                        BrewingTimeSeconds = (int)RecipeBrewingTime.Value,
                        RecipeIngredients = _selectedIngredients.ToList()
                    };

                    await _recipeService.AddPotionRecipe(recipe);
                }
                else {
                    _existing.Name = RecipeName.Text.Trim();
                    _existing.Description = RecipeDescription.Text.Trim();
                    _existing.BrewingTimeSeconds = (int)RecipeBrewingTime.Value;
                    _existing.RecipeIngredients = _selectedIngredients.ToList();

                    await _recipeService.UpdatePotionRecipe(_existing);
                }
                MessageBox.Show("Potion recipe saved!");
                DialogResult = DialogResult.OK;
                Close();

            }
            catch (Exception ex) {
                MessageBox.Show($"Error saving recipe: {ex.Message}");
            }
        }

        public void LoadRecipe(PotionRecipe recipe) {
            if (recipe == null) return;

            _existing = recipe;
            RecipeName.Text = recipe.Name;
            RecipeDescription.Text = recipe.Description;
            RecipeBrewingTime.Value = recipe.BrewingTimeSeconds;

            _selectedIngredients.Clear();
            dataGridView1.Rows.Clear();

            foreach (RecipeIngredient ri in recipe.RecipeIngredients) {
                _selectedIngredients.Add(new RecipeIngredient {
                    IngredientId = ri.IngredientId,
                    Ingredient = ri.Ingredient,
                    QuantityRequired = ri.QuantityRequired
                });

                dataGridView1.Rows.Add(ri.Ingredient?.Name ?? "Unknown", ri.QuantityRequired);
            }
        }

        private void RemoveIngredientBtn_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var selectedRow = dataGridView1.SelectedRows[0];
            int index = selectedRow.Index;

            if (index >= 0 && index < _selectedIngredients.Count) {
                _selectedIngredients.RemoveAt(index);
                dataGridView1.Rows.RemoveAt(index);
            }
        }

        private void IngredientCombo_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
