using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.MVC.Controllers
{
    public class MediaController : Controller
    {
        // GET: MediaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MediaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MediaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MediaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MediaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MediaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MediaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MediaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
