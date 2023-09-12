using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.Entities.Interfacess
{
    public interface IHuman
    {
        string GetInfo();
        void Greet(string name);
    }
}
