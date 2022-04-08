//using INTEXPractice.Models;
//using INTEXPractice.Models.ViewModels;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace isintex2.Controllers
//{
//    [Authorize(Roles = "Administrator")]
//    public class AdminController : Controller
//    {
//        private CrashesDbContext _context { get; set; }

//        public AdminController(CrashesDbContext context)
//        {
//            _context = context;
//        }

//        public IActionResult Index(int pageNum = 1)
//        {
//            var crashes = _context.crashes.ToList();
//            int pageSize = 450;
//            var pageData = new CrashViewModel
//            {
//                crashes = _context.crashes
//                            .OrderBy(crash => crash.CRASH_ID)
//                            .Skip((pageNum - 1) * pageSize)
//                            .Take(pageSize),
//                PageInfo = new PageInformation
//                {
//                    NumOfCrashes = _context.crashes.Count(),
//                    CrashesPerPage = pageSize,
//                    CurrentPage = pageNum
//                }
//            };

//            return View(pageData);
//        }

//        [HttpGet]
//        public IActionResult CreateEditCrash()
//        {
//            return View();
//        }

//        [HttpPost] // Create new crash
//        public IActionResult CreateEditCrash(Crash crash)
//        {
//            if (ModelState.IsValid)
//            {
//                crash.CRASH_ID = _context.crashes.Count() + 1;
//                _context.Add(crash);
//                _context.SaveChanges();

//                return RedirectToAction("Index");
//            }

//            return View(crash);
//        }

//        [HttpGet]
//        public IActionResult Edit(int crashId)
//        {
//            ViewBag.Added = false;

//            var crash = _context.crashes.Single(crash => crash.CRASH_ID == crashId);

//            return View("CreateEditCrash", crash);
//        }

//        [HttpPost] // Edit existing crash
//        public IActionResult Edit(Crash crash)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Update(crash);
//                _context.SaveChanges();

//                return RedirectToAction("Index");
//            }

//            return View(crash);
//        }

//        [HttpGet]
//        public IActionResult Delete(int crashId)
//        {
//            var crash = _context.crashes.Single(x => x.CRASH_ID == crashId);

//            return View(crash);
//        }

//        [HttpPost]
//        public IActionResult Delete(Crash crash)
//        {
//            _context.crashes.Remove(crash);
//            _context.SaveChanges();

//            return RedirectToAction("Index");
//        }
//    }
//}
