using PotionBrewery.DAL;
using PotionBrewery.Models;

namespace PotionBrewery.BLL {
    public class RecipeIngredientService {
        private readonly RecipeIngredientRepository _repository;

        public RecipeIngredientService(RecipeIngredientRepository repository) {
            _repository = repository;
        }

        public async Task<List<RecipeIngredient>> GetRecipeIngredients() {
            return await _repository.GetRecipeIngredients();
        }

        public async Task<RecipeIngredient> GetRecipeIngredient(int id) {
            return await _repository.GetRecipeIngredient(id);
        }

        public async Task AddRecipeIngredient(RecipeIngredient ingredient) {
            await _repository.AddRecipeIngredient(ingredient);
        }

        public async Task UpdateRecipeIngredient(RecipeIngredient ingredient) {
            await _repository.UpdateRecipeIngredient(ingredient);
        }
        public async Task DeleteRecipeIngredient(int id) {
            await _repository.DeleteRecipeIngredient(id);
        }
    }
}
