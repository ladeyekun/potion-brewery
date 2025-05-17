using Microsoft.EntityFrameworkCore;
using PotionBrewery.Models;

namespace PotionBrewery.DAL {
    public class PotionRecipeRepository {
        private readonly PotionBreweryDbContext _context;

        public PotionRecipeRepository(PotionBreweryDbContext context) {
            _context = context;
        }

        public async Task<List<PotionRecipe>> GetPotionRecipes() {
            return await _context.PotionRecipes
                .Include(ri => ri.RecipeIngredients)
                .Include(bp => bp.BrewedPotions)
                .ToListAsync();
        }

        public async Task<PotionRecipe> GetPotionRecipe(int id) {
            return await _context.PotionRecipes
                .Include(ri => ri.RecipeIngredients)
                .Include(bp => bp.BrewedPotions)
                .SingleOrDefaultAsync(pr => pr.RecipeId == id);
        }

        public async Task AddPotionRecipe(PotionRecipe recipe) {
            _context.PotionRecipes.Add(recipe);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePotionRecipe(PotionRecipe recipe) {
            PotionRecipe existingPotionRecipe = await _context.PotionRecipes.FindAsync(recipe.RecipeId);
            if (existingPotionRecipe == null) {
                throw new Exception("Potion Recipe not found");
            }
            existingPotionRecipe.Name = recipe.Name;
            existingPotionRecipe.Description = recipe.Description;
            existingPotionRecipe.BrewingTimeSeconds = recipe.BrewingTimeSeconds;
            _context.Update(existingPotionRecipe);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePotionRecipe(int id) {
            PotionRecipe existingPotionRecipe = await _context.PotionRecipes.FindAsync(id);
            if (existingPotionRecipe == null) {
                throw new Exception("Potion Recipe not found");
            }
            else {
                _context.PotionRecipes.Remove(existingPotionRecipe);
                await _context.SaveChangesAsync();
            }
        }
    }
}
