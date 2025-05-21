using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using PotionBrewery.BLL;
using PotionBrewery.Models;

namespace Potion_Brewery {
    public partial class PotionRecipeForm : Form {
        private readonly PotionRecipeService _recipeService;
        private readonly IngredientService _ingredientService;
        private readonly IServiceProvider _serviceProvider;
        //public PotionRecipeForm(PotionRecipeService recipeService, IngredientService ingredientService, IServiceProvider serviceProvider) {
        public PotionRecipeForm(PotionRecipeService recipeService, IngredientService ingredientService) {
            InitializeComponent();
            _recipeService = recipeService;
            _ingredientService = ingredientService;
            //_serviceProvider = serviceProvider;
        }

        private async void PotionRecipeForm_Load(object sender, EventArgs e) {
            await LoadRecipes();
        }

        private async Task LoadRecipes() {
            List<PotionRecipe> recipes = await _recipeService.GetPotionRecipes();
            dataGridView1.DataSource = recipes
                .Select(r => new {
                    r.RecipeId,
                    r.Name,
                    r.Description,
                    r.BrewingTimeSeconds
                })
                .ToList();
        }

        private void AddRecipeBtn_Click(object sender, EventArgs e) {
            using (var editorForm = new PotionRecipeEditorForm(_ingredientService, _recipeService, null)) {
                if (editorForm.ShowDialog() == DialogResult.OK) {
                    LoadRecipes();
                }
            }
        }

        private async void EditRecipeBtn_Click(object sender, EventArgs e) {
            if (dataGridView1.CurrentRow != null) {
                int recipeId = (int)dataGridView1.CurrentRow.Cells["RecipeId"].Value;
                PotionRecipe recipe = await _recipeService.GetPotionRecipe(recipeId);
                using (var recipeEditorForm = new PotionRecipeEditorForm(_ingredientService, _recipeService, recipe)) {

                    if (recipeEditorForm.ShowDialog() != DialogResult.OK) {
                        LoadRecipes();
                    }
                }
            }
            else {
                MessageBox.Show("Please select a recipe to edit.");
            }
        }

        private async void DeleteRecipeBtn_Click(object sender, EventArgs e) {
            if (dataGridView1.CurrentRow != null) {
                int recipeId = (int)dataGridView1.CurrentRow.Cells["RecipeId"].Value;
                var confirm = MessageBox.Show("Are you sure you want to delete this recipe?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes) {
                    await _recipeService.DeletePotionRecipe(recipeId);
                    await LoadRecipes();
                }
            }
            else {
                MessageBox.Show("Please select a recipe to edit.");
            }
        }
    }
}
