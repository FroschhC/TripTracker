using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
    public class Repository
    {

        private List<Trip> MyTrips = new List<Trip>
        {
            new Trip {

                Id = 1,
                Name = "Healthcare Summit",
                StartDate = new DateTime(2020, 3, 5),
                EndDate = new DateTime(2020, 3, 10)

            },
            new Trip {

                Id = 2,
                Name = "Dev Conf 2020",
                StartDate = new DateTime(2020, 7, 25),
                EndDate = new DateTime(2020, 7, 27)

            },
            new Trip {

                Id = 3,
                Name = "2020 Build",
                StartDate = new DateTime(2020, 12, 1),
                EndDate = new DateTime(2020, 12, 4)

            }
        };

        public List<Trip> Get()
        {
            return MyTrips;
        }

        public Trip Get(int id)
        {
            return MyTrips.First(t => t.Id == id);
        }

        public void Add(Trip newTrip)
        {
            MyTrips.Add(newTrip);
        }

        public void Update(Trip tripToUpdate)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == tripToUpdate.Id));
            Add(tripToUpdate);
        }

        public void Remove(int id)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == id));
        }
    }
}
