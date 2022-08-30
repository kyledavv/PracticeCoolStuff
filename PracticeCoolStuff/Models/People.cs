using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PracticeCoolStuff.Models
{
    public class People
    {
        [Key, ScaffoldColumn(false)]
        public int PersonID { get; set; }

        [Required, StringLength(100), Display(Name = "First Name")]
        public string PersonFirstName { get; set; }

        [Required, StringLength(100), Display(Name = "Last Name")]
        public string PersonLastName { get; set; }

        [Required, StringLength(2), Display(Name = "USTA Level")]
        public string PersonUSTALevel { get; set; }

        [Display(Name = "Age")]
        public int PersonAge { get; set; }

        public int? RacquetID { get; set; }
    }
}