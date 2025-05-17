using Microsoft.EntityFrameworkCore;
using PotionBrewery.Models;

namespace PotionBrewery.DAL {
    public class PotionBreweryDbContext : DbContext {
        public PotionBreweryDbContext() { }
        public PotionBreweryDbContext(DbContextOptions<PotionBreweryDbContext> options) : base(options) { }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<PotionRecipe> PotionRecipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<BrewedPotion> BrewedPotions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Server=TOSHIVAA50FW111\\SQLEXPRESS;Database=PotionBrewery;Integrated Security=True;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            // Primary Keys
            modelBuilder.Entity<RecipeIngredient>()
                .HasKey(ri => ri.RecipeIngredientId);

            modelBuilder.Entity<BrewedPotion>()
                .HasKey(bp => bp.BrewedPotionId);

            modelBuilder.Entity<PotionRecipe>()
                .HasKey(r => r.RecipeId);

            modelBuilder.Entity<Ingredient>()
                .HasKey(i => i.IngredientId);

            //Unique Constraints
            modelBuilder.Entity<Ingredient>()
                .HasIndex(i => i.Name)
                .IsUnique();

            modelBuilder.Entity<PotionRecipe>()
                .HasIndex(pr => pr.Name)
                .IsUnique();

            modelBuilder.Entity<RecipeIngredient>()
                .HasIndex(ri => new { ri.RecipeId, ri.IngredientId })
                .IsUnique();

            // Relationships
            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Recipe)
                .WithMany(r => r.RecipeIngredients)
                .HasForeignKey(ri => ri.RecipeId);

            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Ingredient)
                .WithMany(i => i.RecipeIngredients)
                .HasForeignKey(ri => ri.IngredientId);

            modelBuilder.Entity<BrewedPotion>()
                .HasOne(bp => bp.Recipe)
                .WithMany(pr => pr.BrewedPotions)
                .HasForeignKey(bp => bp.RecipeId);

            modelBuilder.Entity<Ingredient>()
                .Property(i => i.Name)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Ingredient>()
                .Property(i => i.StockQuantity)
                .IsRequired();

            modelBuilder.Entity<Ingredient>()
                .Property(i => i.MinThreshold)
                .IsRequired();

            modelBuilder.Entity<PotionRecipe>()
                .Property(i => i.Name)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<PotionRecipe>()
                .Property(i => i.Description)
                .HasMaxLength(200)
                .IsRequired();

            modelBuilder.Entity<PotionRecipe>()
                .Property(i => i.BrewingTimeSeconds)
                .IsRequired();

            modelBuilder.Entity<RecipeIngredient>()
                .Property(i => i.RecipeId)
                .IsRequired();

            modelBuilder.Entity<RecipeIngredient>()
                .Property(i => i.IngredientId)
                .IsRequired();

            modelBuilder.Entity<RecipeIngredient>()
                .Property(i => i.QuantityRequired)
                .IsRequired();

            modelBuilder.Entity<BrewedPotion>()
                .Property(i => i.RecipeId)
                .IsRequired();

            modelBuilder.Entity<BrewedPotion>()
                .Property(i => i.CustomName)
                .HasMaxLength (100)
                .IsRequired();

            modelBuilder.Entity<BrewedPotion>()
                .Property(i => i.Attributes)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<BrewedPotion>()
                .Property(i => i.BrewAt)
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
