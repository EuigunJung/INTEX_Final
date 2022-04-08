using INTEXPractice.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace isintex2.Components
{
    public class CrashViewComponent : ViewComponent
    {
        private CrashesDbContext _context { get; set; }

        public CrashViewComponent(CrashesDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedSeverity = RouteData?.Values["severity"];

            var Crash = _context.crashes
                //.Select(x => x.CRASH_SEVERITY_ID)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            return View(Crash);
        }
    }
}
