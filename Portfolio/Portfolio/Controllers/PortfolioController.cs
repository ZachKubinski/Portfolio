using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }
        public IActionResult FileIO()
        {
            return View(viewName: "FileIO", model: 0);
        }
        public IActionResult ATM()
        {
            return View(viewName: "ATM", model: 0);
        }
        public IActionResult UnitConverter()
        {
            return View(viewName: "UnitConverter", model: 0);
        }
        public IActionResult FinalProject()
        {
            return View(viewName: "FinalProject", model: 0);
        }
        public IActionResult Bio()
        {
            return View(viewName: "Bio", model: 0);
        }

    }
}