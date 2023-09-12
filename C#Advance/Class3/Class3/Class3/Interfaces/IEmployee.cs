using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3.Interfaces
{
    public interface IEmployee : IDeveloper,ITester
    {
        void PrintInfo();
    }
}
