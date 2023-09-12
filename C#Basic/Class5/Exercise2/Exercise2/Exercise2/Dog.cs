using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        public string Color { get; set; }


        public void Eat()
        {
            Console.WriteLine($"The dog {Name} is now eating");
        }
        public void Play()
        {
            Console.WriteLine($"The dog {Name} with that {Color} is now playing ");
        }
        public void ChaseTail()
        {
            Console.WriteLine( "Dog is now chasing its tail");
        }
        public void Command()
        {
            Console.WriteLine("Chose an activity for the dog: 1- PLay, 2 - ChaseTail, 3 - Eat");
            int command = Convert.ToInt32(Console.ReadLine());  
            switch (command)
            {
                case 1:
                    Play();
                    break;

                case 2:
                    ChaseTail();
                    break;
                case 3:
                    Eat();
                    break;
            }
        }
    }
}
