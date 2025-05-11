using FirstMyProject.Models;

namespace FirstMyProject.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Cake> CakesOfTheWeek { get; }
        public HomeViewModel(IEnumerable<Cake> cakesOfTheWeek)
        {
            CakesOfTheWeek = cakesOfTheWeek;
        }
    }
}
