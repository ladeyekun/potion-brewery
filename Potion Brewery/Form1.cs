using Microsoft.Extensions.DependencyInjection;
using PotionBrewery.BLL;

namespace Potion_Brewery
{
    public partial class Form1 : Form {
        private readonly IServiceProvider _iserviceProvider;
        private readonly IngredientService _ingredientService;
        private readonly PotionRecipeService _recipeService;
        private readonly BrewedPotionService _brewedPotionService;
        public Form1(IServiceProvider iserviceProvider, IngredientService ingredientService, PotionRecipeService recipeService, BrewedPotionService brewedPotionService) {
            InitializeComponent();
            _iserviceProvider = iserviceProvider;
            _ingredientService = ingredientService;
            _recipeService = recipeService;
            _brewedPotionService = brewedPotionService;

            /*
            var btnManageIngredients1 = new Button {
                Text = "Manage Ingredients 1",
                Width = 200,
                Height = 40,
                Top = 20,
                Left = 20
            };

            btnManageIngredients1.Click += (s, e) => {
                var ingredientForm = _serviceProvider.GetRequiredService<IngredientForm>();
                ingredientForm.ShowDialog();
            };

            Controls.Add(btnManageIngredients1);
            */
        }

        private async void Form1_Load(object sender, EventArgs e) {
            await LoadDashboardStats();
        }

        private async Task LoadDashboardStats() {
            int totalIngredient = await _ingredientService.GetTotalIngredientCount();
            int lowStock = await _ingredientService.GetLowStockCount();
            int totalRecipes = await _recipeService.GetTotalPotionRecipes();

            TotalIngredientLabel.Text = $"{totalIngredient}";
            LowStockLabel.Text = $"{lowStock}";
            TotalRecipesLabel.Text = $"{totalRecipes}";
        }

        private void btnManageIngredients_Click(object sender, EventArgs e) {
            using (IngredientForm ingredientForm = new IngredientForm(_ingredientService)) {
                //if (ingredientForm.ShowDialog() == DialogResult.OK) {

                //}
                ingredientForm.ShowDialog();
            }
        }

        private void btnPotionRecipe_Click(object sender, EventArgs e) {
            using (PotionRecipeForm recipeForm = new PotionRecipeForm(_recipeService, _ingredientService, _iserviceProvider)) {
                //recipeForm.ShowDialog();
                var result = recipeForm.ShowDialog();
                if (result == DialogResult.OK) {
                    //PotionRecipe.LoadRecipes();
                }
            }
        }

        private void ManageBrewingBtn_Click(object sender, EventArgs e) {
            using (PotionBrewingForm brewingForm = new PotionBrewingForm(_recipeService, _ingredientService, _brewedPotionService)) {
                //recipeForm.ShowDialog();
                var result = brewingForm.ShowDialog();
                if (result == DialogResult.OK) {
                    //PotionRecipe.LoadRecipes();
                }
            }
        }
    }
}
