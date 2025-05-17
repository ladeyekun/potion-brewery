namespace PotionBrewery.Models {
    public class PotionRecipe {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BrewingTimeSeconds { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
        public ICollection<BrewedPotion> BrewedPotions { get; set; }
    }
}
