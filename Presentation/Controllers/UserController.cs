﻿using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}