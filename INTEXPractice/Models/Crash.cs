using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace INTEXPractice.Models
{
    public class Crash
    {
        [Key]
        [Required]
        public int CRASH_ID { get; set; }
        ////[Required]
        public string CRASH_DATETIME { get; set; }
        public string ROUTE { get; set; }
        ////[Required(ErrorMessage = "Please enter a mile point.")]
        //public decimal MILEPOINT { get; set; }
        ////[Required(ErrorMessage = "Please enter a latitude.")]
        //public decimal LAT_UTM_Y { get; set; }
        ////[Required(ErrorMessage = "Please enter a longitude.")]
        //public decimal LONG_UTM_X { get; set; }
        //[Required]
        public string CITY { get; set; }
        //[Required]
        public string COUNTY_NAME { get; set; }
        //[Required]
        public int CRASH_SEVERITY_ID { get; set; }
        public string PEDESTRIAN_INVOLVED { get; set; }
        public string WORK_ZONE_RELATED { get; set; }
        public string BICYCLIST_INVOLVED { get; set; }
        public string MOTORCYCLE_INVOLVED { get; set; }
        public string IMPROPER_RESTRAINT { get; set; }
        public string UNRESTRAINED { get; set; }
        public string DUI { get; set; }
        public string INTERSECTION_RELATED { get; set; }
        public string WILD_ANIMAL_RELATED { get; set; }
        public string DOMESTIC_ANIMAL_RELATED { get; set; }
        public string OVERTURN_ROLLOVER { get; set; }
        public string COMMERCIAL_MOTOR_VEH_INVOLVED { get; set; }
        public string TEENAGE_DRIVER_INVOLVED { get; set; }
        public string OLDER_DRIVER_INVOLVED { get; set; }
        public string NIGHT_DARK_CONDITION { get; set; }
        public string SINGLE_VEHICLE { get; set; }
        public string DISTRACTED_DRIVING { get; set; }
        public string DROWSY_DRIVING { get; set; }
        public string ROADWAY_DEPARTURE { get; set; }

        ////[NotMapped]
        ////public DateTime CRASH_DATE => DateTime.Parse(CRASH_DATETIME);
        ////[NotMapped]
        ////private string _WORK_ZONE_RELATED;
        ////public string WORK_ZONE_RELATED
        ////{
        ////    get
        ////    {
        ////        WORK_ZONE_BOOL = _WORK_ZONE_RELATED == "True" ? true : false;
        ////        return _WORK_ZONE_RELATED;
        ////    }
        ////    set
        ////    {
        ////        _WORK_ZONE_RELATED = value;
        ////        WORK_ZONE_BOOL = _WORK_ZONE_RELATED == "True" ? true : false;
        ////    }
        ////}
        ////[NotMapped]
        //public bool WORK_ZONE_RELATED { get; set; }
    }
}
