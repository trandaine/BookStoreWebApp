﻿using Microsoft.AspNetCore.Mvc;

namespace BookStore.MVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
