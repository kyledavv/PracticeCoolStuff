using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PracticeCoolStuff.Models
{
    public class PeopleContext : DbContext
    {
        public PeopleContext() : base("PracticeCoolStuff")
            { }
        public DbSet<People> People { get; set; }
        public DbSet<Racquets> Racquets { get; set; }
        public DbSet<PersonsRacquet> PersonsRacquet { get; set; }
    }
}