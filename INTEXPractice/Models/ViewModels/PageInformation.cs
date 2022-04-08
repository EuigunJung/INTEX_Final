using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEXPractice.Models.ViewModels
{
    public class PageInformation
    {
        public int NumOfCrashes { get; set; }
        public int CrashesPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling(((double)NumOfCrashes / CrashesPerPage));
    }
}
