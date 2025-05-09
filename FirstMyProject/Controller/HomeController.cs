using FirstMyProject.Models;
using FirstMyProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstMyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;

        public HomeController(ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
        }
        public IActionResult Index()
        {
            var cakeOfTheWeek = _cakeRepository.CakeOfTheWeek;
            var homeViewModel = new HomeViewModel(cakeOfTheWeek);
            return View(homeViewModel);
        }
    }
}
