using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PracticeCoolStuff.Models
{
    public class Racquets
    {
        [Key, ScaffoldColumn(false)]
        public int RacquetID { get; set; }

        [Required, StringLength(50), Display(Name = "Brand")]
        public string RacquetBrand { get; set; }

        [Required, StringLength(50), Display(Name = "Class")]
        public string RacquetClass { get; set; }
        
        [StringLength(50), Display(Name = "Trim")]
        public string RacquetTrim { get; set; }

        [StringLength(15), Display(Name = "Weight")]
        public string RacquetWeight { get; set; }

        [StringLength(30), Display(Name = "Balance")]
        public string RacquetBalance  { get; set; }

        [StringLength(10), Display(Name = "String Pattern")]
        public string RacquetStringPattern { get; set; }

        [Display(Name = "Grip Size")]
        public int? RacquetGripSize { get; set; }

        public int? PersonID { get; set; }



     }
}