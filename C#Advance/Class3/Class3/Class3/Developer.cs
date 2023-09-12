using Class3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    public class Developer : Employee, IEmployee
    {
        public string Code()
        {
            return "Hello There";
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FullName} is {Age} years old");
        }

        public void Test(int numberOfBugs)
        {
            Console.WriteLine($"There is  {numberOfBugs} found bugs!");
        }
    }
}
