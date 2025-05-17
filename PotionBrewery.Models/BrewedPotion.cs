namespace PotionBrewery.Models {
    public class BrewedPotion {
        public int BrewedPotionId { get; set; }
        public int RecipeId { get; set; }
        public PotionRecipe Recipe { get; set; }
        public string CustomName { get; set; }
        public string Attributes { get; set; }
        public DateTime BrewAt { get; set; } = DateTime.Now;

    }
}
