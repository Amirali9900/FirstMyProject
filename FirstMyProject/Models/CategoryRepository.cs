
namespace FirstMyProject.Models
{
    public class CategoryRepository(CakeShopDbContext cakeShopDbContext) : ICategoryRepository
    {
        private readonly CakeShopDbContext _cakeShopDbContext = cakeShopDbContext;

        public IEnumerable<Category> AllCategories => _cakeShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
