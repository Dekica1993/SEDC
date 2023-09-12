using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.Entities
{
    public class Developer : Human, IDeveloper
    {
        public Developer(string fullName, int age, long phone, List<string> languages,int expirience) : base(fullName, age, phone)
        {
            ProgrammingLanguages = languages;
            YearsOfExperience = expirience;
        }

        public List<string> ProgrammingLanguages { get; set; }
        public int YearsOfExperience { get; set; }
        public override string GetInfo()
        {
            return $"{FullName} ({Age} - {YearsOfExperience}) years of experience!";
        }
         public void Code()
        {
            Console.WriteLine("shtak shtrak");
            Console.WriteLine("shtak shtrak");
            Console.WriteLine("shtak shtrak");




        }
    }
}
