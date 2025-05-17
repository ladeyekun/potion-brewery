using PotionBrewery.DAL;
using PotionBrewery.Models;

namespace PotionBrewery.BLL {
    public class PotionRecipeService {
        private readonly PotionRecipeRepository _repository;

        public PotionRecipeService(PotionRecipeRepository repository) {
            _repository = repository;
        }

        public async Task<List<PotionRecipe>> GetPotionRecipes() {
            return await _repository.GetPotionRecipes();
        }

        public async Task<PotionRecipe> GetPotionRecipe(int id) {
            return await _repository.GetPotionRecipe(id);
        }

        public async Task AddPotionRecipe(PotionRecipe recipe) {
            await _repository.AddPotionRecipe(recipe);
        }

        public async Task UpdatePotionRecipe(PotionRecipe recipe) {
            await _repository.UpdatePotionRecipe(recipe);
        }
        public async Task DeletePotionRecipe(int id) {
            await _repository.DeletePotionRecipe(id);
        }
    }
}
