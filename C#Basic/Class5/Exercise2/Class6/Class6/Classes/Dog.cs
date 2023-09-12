using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6.Classes
{
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }
        public void PrintName()
        {
            Console.WriteLine($"{Name}");
        }
        public void PrintId()
        {
            Console.WriteLine($"{id}");
        }
        public void PrintPrivateProperty()
        {
            //Console.WriteLine($"{_privateProperty}");
        }
       public Dog()
        {
            Console.WriteLine("");
        }
        public void Eat()
        {
            Console.WriteLine("The dog love to eat");
        }
        public override void Eat(string food)
        {
            
            Console.WriteLine($"ThE dog {Name} love to eat that {food}");
        }
        public Dog(string name, string color, string breed) : base(name, color)
        {
            
            Breed = breed;
            Console.WriteLine("Dog's constructor with parmetars was called");

           
        }
    }
}
