using Microsoft.EntityFrameworkCore;
using PotionBrewery.Models;

namespace PotionBrewery.DAL {
    public class IngredientRepository {
        private readonly PotionBreweryDbContext _context;

        public IngredientRepository(PotionBreweryDbContext context) {
            _context = context;
        }

        public async Task<List<Ingredient>> GetIngredients() {
            return await _context.Ingredients
                .Include(ri => ri.RecipeIngredients)
                .ToListAsync();
        }

        public async Task<Ingredient> GetIngredient(int id) {
            return await _context.Ingredients
                .Include(ri => ri.RecipeIngredients)
                .SingleOrDefaultAsync(i => i.IngredientId == id);
        }

        public async Task AddIngredient(Ingredient ingredient) {
            _context.Ingredients.Add(ingredient);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateIngredient(Ingredient ingredient) {
            Ingredient existingIngredient = await _context.Ingredients.FindAsync(ingredient.IngredientId);
            if (existingIngredient == null) {
                throw new Exception("Ingredient not found");
            }
            existingIngredient.Name = ingredient.Name;
            existingIngredient.MinThreshold = ingredient.MinThreshold;
            existingIngredient.StockQuantity = ingredient.StockQuantity;
            _context.Update(existingIngredient);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteIngredient(int id) {
            Ingredient existingIngredient = await _context.Ingredients.FindAsync(id);
            if (existingIngredient == null) {
                throw new Exception("Ingredient not found");
            }
            else {
                _context.Ingredients.Remove(existingIngredient);
                await _context.SaveChangesAsync();
            }
        }
    }
}
