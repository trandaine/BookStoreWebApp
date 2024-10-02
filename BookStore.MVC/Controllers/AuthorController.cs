using Microsoft.AspNetCore.Mvc;

namespace BookStore.MVC.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
