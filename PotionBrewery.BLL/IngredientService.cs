using Microsoft.EntityFrameworkCore;
using PotionBrewery.DAL;
using PotionBrewery.Models;

namespace PotionBrewery.BLL {
    public class IngredientService {
        private readonly IngredientRepository _repository;

        public IngredientService(IngredientRepository repository) {
            _repository = repository;
        }

        public async Task<List<Ingredient>> GetIngredients() {
            return await _repository.GetIngredients();
        }

        public async Task<Ingredient> GetIngredient(int id) {
            return await _repository.GetIngredient(id);
        }

        public async Task AddIngredient(Ingredient ingredient) {
            await _repository.AddIngredient(ingredient);
        }

        public async Task UpdateIngredient(Ingredient ingredient) {
            await _repository.UpdateIngredient(ingredient);
        }
        public async Task DeleteIngredient(int id) {
            await _repository.DeleteIngredient(id);
        }

        public async Task<int> GetTotalIngredientCount() {
            List<Ingredient> ingredients = await _repository.GetIngredients();
            return ingredients.Count(); 
        }

        public async Task<int> GetLowStockCount() {
            List<Ingredient> ingredients = await _repository.GetIngredients();
            return ingredients.Count(i => i.StockQuantity < i.MinThreshold);
        }

        public async Task<List<Ingredient>> GetMostUsedIngredients() {
            return await _repository.GetMostUsedIngredients();
        }
    }
}
