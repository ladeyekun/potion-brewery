using Microsoft.EntityFrameworkCore;
using PotionBrewery.Models;

namespace PotionBrewery.DAL {
    public class RecipeIngredientRepository {
        private readonly PotionBreweryDbContext _context;

        public RecipeIngredientRepository(PotionBreweryDbContext context) {
            _context = context;
        }

        public async Task<List<RecipeIngredient>> GetRecipeIngredients() {
            return await _context.RecipeIngredients
                .Include(r => r.Recipe)
                .Include(i => i.Ingredient)
                .ToListAsync();
        }

        public async Task<RecipeIngredient> GetRecipeIngredient(int id) {
            return await _context.RecipeIngredients
                .Include(r => r.Recipe)
                .Include(i => i.Ingredient)
                .SingleOrDefaultAsync(ri => ri.RecipeIngredientId == id);
        }

        public async Task AddRecipeIngredient(RecipeIngredient ingredient) {
            _context.RecipeIngredients.Add(ingredient);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRecipeIngredient(RecipeIngredient ingredient) {
            RecipeIngredient existingRecipeIngredient = await _context.RecipeIngredients.FindAsync(ingredient.RecipeIngredientId);
            if (existingRecipeIngredient == null) {
                throw new Exception("Recipe Ingredient not found");
            }
            existingRecipeIngredient.RecipeId = ingredient.RecipeId;
            existingRecipeIngredient.IngredientId = ingredient.IngredientId;
            existingRecipeIngredient.QuantityRequired = ingredient.QuantityRequired;
            _context.Update(existingRecipeIngredient);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRecipeIngredient(int id) {
            RecipeIngredient existingRecipeIngredient = await _context.RecipeIngredients.FindAsync(id);
            if (existingRecipeIngredient == null) {
                throw new Exception("Recipe Ingredient not found");
            }
            else {
                _context.RecipeIngredients.Remove(existingRecipeIngredient);
                await _context.SaveChangesAsync();
            }
        }

    }
}
