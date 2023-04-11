using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorZoo
{
    class Leu : Animal
    {
        public string sexul;
        public Leu(string Name, int Age, int Life , string Sexul) 
            : base(Name, Age, Life)
        {
            this.sexul= Sexul;
        }

      
    }
}
