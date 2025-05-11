using Microsoft.AspNetCore.Mvc;
using FirstMyProject.Models;
using FirstMyProject.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Collections;

namespace FirstMyProject.Controllers
{
    public class CakeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CakeController(ICakeRepository cakeRepository, ICategoryRepository categoryRepository)
        {
            _cakeRepository = cakeRepository;
            _categoryRepository = categoryRepository;
        }

        //public IActionResult List()
        //{
        //    CakeListVIewModel cakeListVIewModel = new CakeListVIewModel(_cakeRepository.AllCake , "All Cake");
        //    return View(cakeListVIewModel);
        //}

        public ViewResult List(string category)
        {
            IEnumerable<Cake> cakes;
            string? currentlycategory;

            if (string.IsNullOrEmpty(category))
            {
                cakes = _cakeRepository.AllCake.OrderBy(p => p.CakeID);
                currentlycategory = "All Cake";
            }
            else
            {
                cakes = _cakeRepository.AllCake.Where(p => p.Category.CategoryName == category).OrderBy(p => p.CakeID);
                currentlycategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new CakeListVIewModel(cakes, currentlycategory));
        }
        public IActionResult Details(int id)
        {
            var cake = _cakeRepository.GetCakeById(id);
            if (cake == null)
                return NotFound();
            return View(cake);
        }
    }
}
