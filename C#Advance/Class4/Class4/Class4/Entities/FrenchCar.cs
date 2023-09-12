using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4.Entities
{
    public class FrenchCar: Car
    {
      public  bool Navigation { get; set; }

      public FrenchCar(string brand, FuelType fuelType,string model,DateTime yearOfProduction,int horsePower,bool navigation)
        {
            Brand = brand;
            FuelType = FuelType;
            Model = model;
           YearOfProduction = yearOfProduction;
            HorsePower = horsePower;
            Navigation = navigation;
        }
        public static void PrintNavigation()
        {
            Console.WriteLine("These days in all cars have navigation");
        }
    }
}
