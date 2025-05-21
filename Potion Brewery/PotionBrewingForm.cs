using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PotionBrewery.BLL;
using PotionBrewery.Models;

namespace Potion_Brewery {
    public partial class PotionBrewingForm : Form {
        private readonly PotionRecipeService _recipeService;
        private readonly IngredientService _ingredientService;
        private readonly BrewedPotionService _brewedPotionService;
        private readonly IServiceProvider _serviceProvider;
        private List<PotionRecipe> _recipes = new();

        public PotionBrewingForm(PotionRecipeService recipeService, IngredientService ingredientService, BrewedPotionService brewedPotionService) {
            InitializeComponent();
            _recipeService = recipeService;
            _ingredientService = ingredientService;
            _brewedPotionService = brewedPotionService;
        }

        private async void PotionBrewingForm_Load(object sender, EventArgs e) {
            await LoadRecipes();
            await LoadBrewedPotions();
        }

        private async Task LoadRecipes() {
            _recipes = await _recipeService.GetPotionRecipes();
            RecipesCombo.DataSource = _recipes;
            RecipesCombo.DisplayMember = "Name";
            RecipesCombo.ValueMember = "RecipeId";
        }

        private async Task LoadBrewedPotions() {
            List<BrewedPotion> brewedPotions = await _brewedPotionService.GetBrewedPotions();
            BrewedPotionGrid.DataSource = brewedPotions
                .Select(r => new {
                    r.BrewedPotionId,
                    r.CustomName,
                    r.Attributes,
                    r.BrewAt
                })
                .ToList();
        }


        private void StatusLabel_Click(object sender, EventArgs e) {

        }

        private async void RecipesCombo_SelectedIndexChanged(object sender, EventArgs e) {
            var selectedRecipe = RecipesCombo.SelectedItem as PotionRecipe;
            if (selectedRecipe == null) return;

            dataGridView1.Rows.Clear();
            bool hasEnoughStock = true;

            foreach (RecipeIngredient ri in selectedRecipe.RecipeIngredients) {
                Ingredient ingredient = ri.Ingredient;
                bool enough = ingredient.StockQuantity >= ri.QuantityRequired;
                if (!enough) hasEnoughStock = false;

                dataGridView1.Rows.Add(ingredient.Name, ri.QuantityRequired, ingredient.StockQuantity, enough ? "Yes" : "No");
            }
            StartBrewingBtn.Enabled = hasEnoughStock;
            StatusLabel.Visible = !hasEnoughStock;
        }

        private async void StartBrewingBtn_Click(object sender, EventArgs e) {
            PotionRecipe recipe = RecipesCombo.SelectedItem as PotionRecipe;
            if (recipe == null) return;

            string customName = CustomName.Text.Trim();
            string attributes = CustomAttributes.Text.Trim();
            if (customName.Length <= 0 || attributes.Length <= 0) {
                MessageBox.Show("Please enter a custom name and attributes for the potion.");
                return;
            }

            BrewingProgressBar.Value = 0;
            StartBrewingBtn.Enabled = false;
            StatusLabel.Text = "Brewing in progress...";

            int total = recipe.BrewingTimeSeconds * 10;
            
            for (int i = 0; i <= total; i++) {
                await Task.Delay(100);
                BrewingProgressBar.Value = Math.Min(100, (i * 100) / total);
            }

            foreach(RecipeIngredient ri in recipe.RecipeIngredients) {
                ri.Ingredient.StockQuantity -= ri.QuantityRequired;
                await _ingredientService.UpdateIngredient(ri.Ingredient);
            }

            BrewedPotion brewedPotion = new BrewedPotion {
                RecipeId = recipe.RecipeId,
                CustomName = customName,
                Attributes = attributes,
                BrewAt = DateTime.Now,
            };
            await _brewedPotionService.AddBrewedPotion(brewedPotion);

            StatusLabel.Text = "Brewing completed!";
            MessageBox.Show("Potion brewed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadBrewedPotions();
            CustomName.Text = "";
            CustomAttributes.Text = "";
            dataGridView1.Rows.Clear();

            RecipesCombo_SelectedIndexChanged(null, null);
        }
    }
}
