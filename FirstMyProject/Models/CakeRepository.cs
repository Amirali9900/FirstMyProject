using Microsoft.EntityFrameworkCore;

namespace FirstMyProject.Models
{
    public class CakeRepository : ICakeRepository
    {
        private readonly CakeShopDbContext _cakeShopDbContext;
        public CakeRepository(CakeShopDbContext cakeShopDbContext)
        {
            _cakeShopDbContext = cakeShopDbContext;
        }

        public IEnumerable<Cake> AllCake
        {
            get
            {
                return _cakeShopDbContext.Cakes.Include(c => c.Category);
            }
        }
        public IEnumerable<Cake> CakesOfTheWeek
        {
            get
            {
                return _cakeShopDbContext.Cakes.Include(c => c.Category).Where(p => p.IsCakeOfTheWeek);
            }
        }
        public Cake? GetCakeById(int cakeId)
        {
            return _cakeShopDbContext.Cakes.FirstOrDefault(p => p.CakeId == cakeId);
        }
        public IEnumerable<Cake> SearchCakes(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
