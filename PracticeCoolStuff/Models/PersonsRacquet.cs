using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PracticeCoolStuff.Models
{
    public class PersonsRacquet
    {
        [Key, Required]
        public int ID { get; set; }

        [Required]
        public int PersonID { get; set; }
        
        [Required]
        public int RacquetID { get; set; }


    }
}