using BikeApp.Models.Enum;

namespace BikeApp.Models.Domain
{
    public class Bike
    {
        public int Id { get; set; } 
        public string Brand { get; set; }
        public int WheelDiametar { get; set; }
        public int Gears { get; set; }
        public bool HasHydraulicBreaks { get; set; }
        public BikeType BikeType { get; set; }
    }
}
