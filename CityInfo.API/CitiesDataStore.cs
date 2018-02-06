using CityInfo.API.Models;
using System.Collections.Generic;

namespace CityInfo.API
{
    public class CitiesDataStore
    {


        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "NYC",
                    Description = "The one with the apple",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The big park with the most visits in US"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "The tallest skyscraper located in Manhattan"
                        }

                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Seattle",
                    Description = "The crowded one",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Space Needle",
                            Description = "Good place to visit"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Century Link Field",
                            Description = "Home of the Seahawks"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Portland",
                    Description = "The rainy one",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Montgomery PArk",
                            Description = "A tall building in NW Pdx"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Pioneer Square",
                            Description = "Downtown PDX"
                        }
                    }
                }
            };
        }
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
    }
}
