using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorZoo
{
    class Maimuta : Animal
    {
        public string Rasa;
        public Maimuta(string Name, int Age, int Life , string Rasa) 
            : base(Name, Age, Life) //apeleaza constructorul din clasa de baza.
        {
            this.Rasa= Rasa;
        }
    }
}
