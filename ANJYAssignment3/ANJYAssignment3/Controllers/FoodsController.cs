using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ANJYAssignment3.Controllers
{
    public class FoodsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}