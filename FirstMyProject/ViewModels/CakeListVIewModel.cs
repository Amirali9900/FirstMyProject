using FirstMyProject.Models;

namespace FirstMyProject.ViewModels
{
    public class CakeListVIewModel
    {
        public IEnumerable<Cake> Cakes { get; }
        public string? CurrentCategory {  get; }
        public CakeListVIewModel(IEnumerable<Cake> cakes,string? currentCategory)
        {
            Cakes = cakes;
            CurrentCategory = currentCategory;
        }
    }
}
