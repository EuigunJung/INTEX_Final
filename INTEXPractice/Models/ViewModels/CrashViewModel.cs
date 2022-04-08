using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEXPractice.Models.ViewModels
{
    public class CrashViewModel
    {
        public IQueryable<Crash> crashes { get; set; }
        public PageInformation PageInfo { get; set; }
    }
}
