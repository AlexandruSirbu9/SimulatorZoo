using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorZoo
{
    public class Maimuta : Animal
    {
        public string Rasa;
        public Maimuta(string Name, int Age , string Rasa) 
            : base(Name, Age) //apeleaza constructorul din clasa de baza.
        {
            this.Rasa= Rasa;
            this.VarstaMaxima = 10;
        }
    }
}
