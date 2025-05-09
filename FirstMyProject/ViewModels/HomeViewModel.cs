using FirstMyProject.Models;

namespace FirstMyProject.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Cake> CakeOfTheWeek { get; }
        public HomeViewModel(IEnumerable<Cake> cakeOfTheWeek)
        {
            CakeOfTheWeek = cakeOfTheWeek;
        }
    }
}
