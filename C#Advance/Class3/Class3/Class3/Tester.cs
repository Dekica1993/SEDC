using Class3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    public class Tester : Employee, ITester
    {
        public void Test(int numberOfBugs)
        {
            Console.WriteLine($"Testing {numberOfBugs} bugs");
        }
    }
}
