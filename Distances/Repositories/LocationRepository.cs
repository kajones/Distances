using System.Collections.Generic;
using Distances.Models;

namespace Distances.Repositories
{
    public class LocationRepository
    {
        public List<Location> GetAll()
        {
            return new List<Location>
            {
                new Location { LocationType = LocationType.Beacon, Name = "Firle Beacon", Rad = 0.887194, Longitude = 0.0817484},
                new Location { LocationType = LocationType.Beacon, Name = "The Beacon Kington", Rad = 0.911286, Longitude = -3.0409732},
                new Location { LocationType = LocationType.Beer, Name = "Hook Norton Brewery", Rad = 0.907518, Longitude = -1.49482},
                new Location { LocationType = LocationType.Beer, Name = "St Albans pub", Rad = 0.903182, Longitude = -0.333377},
                new Location { LocationType = LocationType.CarPark, Name = "Perranporth", Rad = 0.878663, Longitude = -5.1546},
                new Location { LocationType = LocationType.CarPark, Name = "Orford Quay St", Rad = 0.909181, Longitude = 1.537029},
                new Location { LocationType = LocationType.Lion, Name = "Kidstone Cross Islay", Rad = 0.971867, Longitude = -6.044444},
                new Location { LocationType = LocationType.Lion, Name = "Balmoral Castle", Rad = 0.99555, Longitude = -3.23},
                new Location { LocationType = LocationType.Pub, Name = "The Bridge", Rad = 0.943972, Longitude = -1.763787},
                new Location { LocationType = LocationType.Pub, Name = "Black Swan Ockham", Rad = 0.895319, Longitude = -0.461},
                new Location { LocationType = LocationType.Quarry, Name = "Coniston", Rad = 0.948937, Longitude = -3.1221121},
                new Location { LocationType = LocationType.Quarry, Name = "Pitstone", Rad = 0.904516, Longitude = -0.617847}
            };
        }
    }
}
