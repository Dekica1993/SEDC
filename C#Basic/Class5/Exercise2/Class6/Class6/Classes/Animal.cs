using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6.Classes
{
    public class Animal
    {
        
        protected int id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        private string _privateProperty { get; set; }

        public Animal ()
        {

            id = new Random().Next(1, 99999999);
            Console.WriteLine("Parametarless constructor called!");
        }
        public Animal (string name, string color)
        {
            id = new Random().Next(1,99999999);
            Name = name;
            Color = color;
            Console.WriteLine("Constructor with parametars was cancel");
        }
        public void PrintBasicInfo()
        {
            Console.WriteLine($"id; {id},Name; {Name},Color;{Color}");
        }
        public virtual void Eat(string food)
        {
            Console.WriteLine($"The animal {Name} eats {food}");
        }

    }
}
