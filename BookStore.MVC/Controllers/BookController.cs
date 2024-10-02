using Microsoft.AspNetCore.Mvc;

namespace BookStore.MVC.Controllers
{
    public class BookController : Controller
    {
        private readonly ILogger<BookController> _logger;
        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            try
            {

            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
            }
            return View();
        }
    }
}
