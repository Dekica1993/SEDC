using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6.Classes
{
    internal class Cat:Animal
    {
        public bool IsLazy { get; set; }
        public void Talk()
        {
            Console.WriteLine($"The cat {Name} is talking");
        }
        public Cat()
        {
            Console.WriteLine("Cats's parametarles constructor");
        }
        public override void Eat (string food)
        {
            Console.WriteLine ($"The cat {Name} eats {food}");
        }

    }
}
