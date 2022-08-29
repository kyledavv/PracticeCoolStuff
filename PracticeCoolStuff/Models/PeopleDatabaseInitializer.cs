using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PracticeCoolStuff.Models
{
    public class PeopleDatabaseInitializer : DropCreateDatabaseIfModelChanges<PeopleContext>
    {
        protected  override void Seed(PeopleContext context)
        {
            GetRacquets().ForEach(r => context.Racquets.Add(r));
            GetPeople().ForEach(p => context.People.Add(p));
        }

        private static List<Racquets> GetRacquets()
        {
            var racquets = new List<Racquets>
            {
                new Racquets
                {
                    RacquetID = 1,
                    RacquetBrand = "Wilson",
                    RacquetClass = "Blade",
                    RacquetTrim = "98 18x20",
                    RacquetWeight = "10.8oz",
                    RacquetBalance = "8pts HL",
                    RacquetStringPattern = "18x20",
                    RacquetGripSize = 3,
                },
                new Racquets
                {
                    RacquetID = 2,
                    RacquetBrand = "Wilson",
                    RacquetClass = "Blade",
                    RacquetTrim = "98 18x20",
                    RacquetWeight = "10.8oz",
                    RacquetBalance = "8pts HL",
                    RacquetStringPattern = "18x20",
                    RacquetGripSize = 1,
                },
                new Racquets
                {
                    RacquetID = 3,
                    RacquetBrand = "Wilson",
                    RacquetClass = "Blade",
                    RacquetTrim = "98 18x20",
                    RacquetWeight = "10.8oz",
                    RacquetBalance = "8pts HL",
                    RacquetStringPattern = "18x20",
                    RacquetGripSize = 2,
                },
                new Racquets
                {
                    RacquetID = 4,
                    RacquetBrand = "Wilson",
                    RacquetClass = "Blade",
                    RacquetTrim = "98 18x20",
                    RacquetWeight = "10.8oz",
                    RacquetBalance = "8pts HL",
                    RacquetStringPattern = "18x20",
                    RacquetGripSize = 4,
                },
                new Racquets
                {
                    RacquetID = 5,
                    RacquetBrand = "Wilson",
                    RacquetClass = "Blade",
                    RacquetTrim = "98 16x19",
                    RacquetWeight = "10.8oz",
                    RacquetBalance = "8pts HL",
                    RacquetStringPattern = "18x20",
                    RacquetGripSize = 1,
                }


            };

            return racquets;
        }

        private static List<People> GetPeople()
        {
            var people = new List<People>
            {
                new People
                {
                    PersonID = 1,
                    PersonFirstName = "Sean",
                    PersonLastName = "Teeter",
                    PersonUSTALevel = "5.0",
                    PersonAge = 32
                },
                new People
                {
                    PersonID = 2,
                    PersonFirstName = "Jamie-Lee",
                    PersonLastName = "Denton",
                    PersonUSTALevel = "5.0",
                    PersonAge = 28
                },
                new People
                {
                    PersonID = 3,
                    PersonFirstName = "Kyle",
                    PersonLastName = "Davidson",
                    PersonUSTALevel = "5.5",
                    PersonAge = 28
                },
            };

            return people;
        }

        private static List<PersonsRacquet> GetPersonsRacquet()
        {
            var personsracquet = new List<PersonsRacquet>
            {
                new PersonsRacquet
                {
                    PersonID = 3,
                    RacquetID = 1,
                }
            };

            return personsracquet;
        }
    }
}