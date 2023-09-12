using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4.Entities
{
    public class GermanCar : Car
    {
        public int MaxSpeed { get; set; }

        public GermanCar(string brand, FuelType fuelType, string model, DateTime yearOfProduction, int horsePower,int maxSpeed)
        {
            Brand = brand;
            FuelType = FuelType;
            Model = model;
            YearOfProduction = yearOfProduction;
            HorsePower = horsePower;
            MaxSpeed = maxSpeed;
        }

        public static void PrintMaxSpeed()
        {
            Console.WriteLine("BUGGATI is beast!");
        }
    }
}
