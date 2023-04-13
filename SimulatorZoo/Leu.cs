using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorZoo
{
    public class Leu : Animal
    {
        public string Sexul;
        public Leu(string Name, int Age , string Sexul) 
            : base(Name, Age)
        {
            this.Sexul= Sexul;
            this.VarstaMaxima = 15;
            this.Age = 3;
        }

        public void MoarteLeu()
        {
            if(Age >= VarstaMaxima) 
            {
                Console.WriteLine("Leul a murit");   
            }
        }

      
    }
}
