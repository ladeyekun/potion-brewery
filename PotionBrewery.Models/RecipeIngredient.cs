namespace PotionBrewery.Models {
    public class RecipeIngredient {
        public int RecipeIngredientId { get; set; }
        public int RecipeId { get; set; }
        public PotionRecipe Recipe { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int QuantityRequired { get; set; }
    }
}
