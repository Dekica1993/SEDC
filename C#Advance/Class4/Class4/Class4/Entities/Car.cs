using Class4.Interfacess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4.Entities
{
    public abstract class Car : ICar
    {
        public string Brand { get; set; }
        public FuelType FuelType { get; set; }
        public string Model { get; set; }
        public DateTime YearOfProduction { get; set; }
        public int HorsePower { get; set; }

        public void Drive(string destinationName)
        {
            Console.WriteLine($"Honda always finish at {destinationName}");
        }

        public void Radio(string songName)
        {
            Console.WriteLine($"When i drive,on radio is always {songName}");
        }
    }
}
