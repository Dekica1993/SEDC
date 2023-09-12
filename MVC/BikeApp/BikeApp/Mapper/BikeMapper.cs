using BikeApp.Models.Domain;
using BikeApp.Models.ViewModels;

namespace BikeApp.Mapper
{
    public static class BikeMapper
    {
        public static BikeViewModel ToBikeViewModel(this Bike bike)
        {
            return new BikeViewModel()
            {
                Id = bike.Id,
                Brand = bike.Brand,
                WheelDiametar = bike.WheelDiametar,
                Gears = bike.Gears,
                HasHydraulicBreaks = bike.HasHydraulicBreaks,
                BikeType = bike.BikeType

            };
        }
    }
}