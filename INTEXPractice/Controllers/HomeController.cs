using INTEXPractice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace INTEXPractice.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //private ICrashesRepository repo { get; set; }
        private CrashesDbContext _context { get; set; }

        //Constructor
        public HomeController(CrashesDbContext temp)
        {
            _context = temp;
            //_context = tempcontext;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Overview()
        {

            var blah = _context.crashes.ToList();

            return View(blah);

        }

        public IActionResult Tableau()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
