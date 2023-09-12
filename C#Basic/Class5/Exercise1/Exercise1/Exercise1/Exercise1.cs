using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public Human (string FirstName, string LastName, int Age)
        {
            FirstName = FirstName;
            LastName = LastName;
            Age = Age;


        }

        public Human()
        {
        }

        public string GetPersonStats()
        {
            return $"{FirstName} {LastName} {Age}";
        }
    }
    
}
