using BikeApp.Models.Domain;
using BikeApp.Models.Enum;

namespace BikeApp
{
    public static class StaticDb
    {
        public static List<Bike> Bikes = new List<Bike>()
        {
            new Bike()
            {
                Id = 1,
                Brand = "Scot",
                WheelDiametar = 14,
                Gears = 7,
                HasHydraulicBreaks = true,
                BikeType = BikeType.Road

            },

            new Bike()
            {
                Id = 2,
                Brand = "Cube",
                WheelDiametar = 18,
                Gears = 4,
                HasHydraulicBreaks = true,
                BikeType = BikeType.Mountine

            },

            new Bike()
            {
                Id = 3,
                Brand = "KTM",
                WheelDiametar = 22,
                Gears = 5,
                HasHydraulicBreaks = false,
                BikeType = BikeType.Mountine

            },

             new Bike()
            {
                Id = 3,
                Brand = "Piagelo",
                WheelDiametar = 12,
                Gears = 3,
                HasHydraulicBreaks = false,
                BikeType = BikeType.City

            },
        };
    }
}
