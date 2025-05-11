using Microsoft.AspNetCore.Mvc;

namespace FirstMyProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
