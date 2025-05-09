using Microsoft.EntityFrameworkCore;

namespace FirstMyProject.Models
{
    public class CakeRepository(CakeShopDbContext cakeShopDbContext) : ICakeRepository
    {
        private readonly CakeShopDbContext _cakeShopDbContext = cakeShopDbContext;

        IEnumerable<Cake> ICakeRepository.AllCake
        {
            get
            {
                return _cakeShopDbContext.Cakes.Include(c => c.Category);
            }
        }
        IEnumerable<Cake> ICakeRepository.CakeOfTheWeek
        {
            get
            {
                return _cakeShopDbContext.Cakes.Include(c => c.Category).Where(p => p.IsCakeOfTheWeek);
            }
        }
        Cake? ICakeRepository.GetCakeById(int cakeId)
        {
            return _cakeShopDbContext.Cakes.FirstOrDefault(p => p.CakeID == cakeId);
        }
    }
}
