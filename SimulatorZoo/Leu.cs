using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorZoo
{
    public class Leu : Animal
    {
        public string sexul;
        public Leu(string Name, int Age , string Sexul) 
            : base(Name, Age)
        {
            this.sexul= Sexul;
            this.VarstaMaxima = 15;
        }

      
    }
}
