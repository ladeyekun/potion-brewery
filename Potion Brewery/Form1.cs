using Microsoft.Extensions.DependencyInjection;
using PotionBrewery.BLL;
using PotionBrewery.Models;

namespace Potion_Brewery
{
    public partial class Form1 : Form {
        private readonly IngredientService _ingredientService;
        private readonly PotionRecipeService _recipeService;
        private readonly BrewedPotionService _brewedPotionService;
        public Form1( IngredientService ingredientService, PotionRecipeService recipeService, BrewedPotionService brewedPotionService) {
            InitializeComponent();
            _ingredientService = ingredientService;
            _recipeService = recipeService;
            _brewedPotionService = brewedPotionService;
        }

        private async void Form1_Load(object sender, EventArgs e) {
            await LoadDashboardStats();
        }

        private async Task LoadDashboardStats() {
            int totalIngredient = await _ingredientService.GetTotalIngredientCount();
            int lowStock = await _ingredientService.GetLowStockCount();
            int totalRecipes = await _recipeService.GetTotalPotionRecipes();
            int totalBrewedPotions = await _brewedPotionService.GetTotalPotionsBrewed();
            int mostIngredientUsed = await _brewedPotionService.GetTotalIngredientsUsed();
            await LoadMostBrewedPotions();
            await LoadMostUsedIngredients();

            TotalIngredientLabel.Text = $"{totalIngredient}";
            LowStockLabel.Text = $"{lowStock}";
            TotalRecipesLabel.Text = $"{totalRecipes}";
            TotalBrewedPotionsValue.Text = $"{totalBrewedPotions}";
            MostIngredientUsedValue.Text = $"{mostIngredientUsed}";
        }

        private async Task LoadMostBrewedPotions() {
            List<MostBrewedPotionDTO> data = await _brewedPotionService.GetMostFrequentlyBrewedPotions();
            MostBrewedPotionsGrid.DataSource = data.Select(d => new {
                Name = d.Recipe.Name,
                Count = d.Count
            }).ToList();
        }

        private async Task LoadMostUsedIngredients() {
            List<Ingredient> data = await _ingredientService.GetMostUsedIngredients();
            MostUsedIngredientGrid.DataSource = data.Select(d => new {
                IngredientName = d.Name,
                UsedInRecipes = d.RecipeIngredients.Count
            }).ToList();
        }


        private void btnManageIngredients_Click(object sender, EventArgs e) {
            using (IngredientForm ingredientForm = new IngredientForm(_ingredientService)) {
                ingredientForm.ShowDialog();
            }
        }

        private void btnPotionRecipe_Click(object sender, EventArgs e) {
            using (PotionRecipeForm recipeForm = new PotionRecipeForm(_recipeService, _ingredientService)) {
                DialogResult result = recipeForm.ShowDialog();
                if (result == DialogResult.OK) {
                }
            }
        }

        private void ManageBrewingBtn_Click(object sender, EventArgs e) {
            using (PotionBrewingForm brewingForm = new PotionBrewingForm(_recipeService, _ingredientService, _brewedPotionService)) {
                DialogResult result = brewingForm.ShowDialog();
                if (result == DialogResult.OK) {
                }
            }
        }
    }
}
