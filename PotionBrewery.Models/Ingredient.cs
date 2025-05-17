namespace PotionBrewery.Models {
    public class Ingredient {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public int StockQuantity { get; set; }
        public int MinThreshold { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
