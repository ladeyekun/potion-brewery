using Microsoft.EntityFrameworkCore;
using PotionBrewery.Models;

namespace PotionBrewery.DAL {
    public class BrewedPotionRepository {
        private readonly PotionBreweryDbContext _context;

        public BrewedPotionRepository(PotionBreweryDbContext context) {
            _context = context;
        }

        public async Task<List<BrewedPotion>> GetBrewedPotions() {
            return await _context.BrewedPotions
                .Include(pr => pr.Recipe)
                .ToListAsync();
        }

        public async Task<BrewedPotion> GetBrewedPotion(int id) {
            return await _context.BrewedPotions
                .Include(pr => pr.Recipe)
                .SingleOrDefaultAsync(b => b.BrewedPotionId == id);
        }

        public async Task AddBrewedPotion(BrewedPotion potion) {
            _context.BrewedPotions.Add(potion);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBrewedPotion(BrewedPotion potion) {
            BrewedPotion existing = await _context.BrewedPotions.FindAsync(potion.BrewedPotionId);
            if (existing == null) {
                throw new Exception("Brewed Potion not found");
            }
            existing.RecipeId = potion.RecipeId;
            existing.CustomName = potion.CustomName;
            existing.Attributes = potion.Attributes;
            existing.BrewAt = potion.BrewAt;
            _context.Update(existing);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBrewedPotion(int id) {
            BrewedPotion existing = await _context.BrewedPotions.FindAsync(id);
            if (existing == null) {
                throw new Exception("Brewed Potion not found");
            }
            else {
                _context.BrewedPotions.Remove(existing);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<MostBrewedPotionDTO>> GetMostFrequentlyBrewedPotions() {
            return await _context.BrewedPotions
                .Include(bp => bp.Recipe)
                .GroupBy(bp => bp.Recipe)
                .Select(g => new MostBrewedPotionDTO {
                    Recipe = g.Key,
                    Count = g.Count()
                })
                .OrderByDescending(x => x.Count)
                .Take(5)
                .ToListAsync();
        }

        public async Task<int> GetTotalIngredientsUsed() {
            List<BrewedPotion> brewedPotion =  await _context.BrewedPotions
                .Include(bp => bp.Recipe)
                .ThenInclude(r => r.RecipeIngredients)
                .ToListAsync();

            return brewedPotion.Sum(p => p.Recipe.RecipeIngredients.Sum(ri => ri.QuantityRequired));
        }
        public async Task<int> GetTotalPotionsBrewed() {
            return await _context.BrewedPotions.CountAsync();
        }

    }
}
