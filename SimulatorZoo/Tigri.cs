using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorZoo
{
    public class Tigri : Animal
    {
        public string Culoarea;
        public Tigri(string Name, int Age , string Culoarea) 
            : base(Name, Age)
        {
            this.Culoarea= Culoarea;
            this.VarstaMaxima = 9;
            this.Age = 1;
        }

        public void MoarteTigri()
        {
            if(Age >= VarstaMaxima)
            {
                Console.WriteLine("Tigru a murit.");
            }
        }
       
    }
}
