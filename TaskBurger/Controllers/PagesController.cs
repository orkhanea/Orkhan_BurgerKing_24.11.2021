using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TaskBurger.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult BookGrid()
        {
            return View();
        }

        public IActionResult BookDetails()
        {
            return View();
        }
    }
}