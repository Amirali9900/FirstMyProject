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
            var cakesOfTheWeek = _cakeRepository.CakesOfTheWeek;
            var homeViewModel = new HomeViewModel(cakesOfTheWeek);
            return View(homeViewModel);
        }
    }
}
