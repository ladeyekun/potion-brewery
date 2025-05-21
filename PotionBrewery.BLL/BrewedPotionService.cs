using Microsoft.EntityFrameworkCore;
using PotionBrewery.DAL;
using PotionBrewery.Models;

namespace PotionBrewery.BLL {
    public class BrewedPotionService {
        private readonly BrewedPotionRepository _repository;

        public BrewedPotionService(BrewedPotionRepository repository) {
            _repository = repository;
        }

        public async Task<List<BrewedPotion>> GetBrewedPotions() {
            return await _repository.GetBrewedPotions();
        }

        public async Task<BrewedPotion> GetBrewedPotion(int id) {
            return await _repository.GetBrewedPotion(id);
        }

        public async Task AddBrewedPotion(BrewedPotion potion) {
            await _repository.AddBrewedPotion(potion);
        }

        public async Task UpdateBrewedPotion(BrewedPotion potion) {
            await _repository.UpdateBrewedPotion(potion);
        }
        public async Task DeleteBrewedPotion(int id) {
            await _repository.DeleteBrewedPotion(id);
        }
        public async Task<List<MostBrewedPotionDTO>> GetMostFrequentlyBrewedPotions() {
            return await _repository.GetMostFrequentlyBrewedPotions();
        }

        public async Task<int> GetTotalPotionsBrewed() {
            return await _repository.GetTotalPotionsBrewed();
        }


        public async Task<int> GetTotalIngredientsUsed() {
            return await _repository.GetTotalIngredientsUsed();
        }

    }
}
