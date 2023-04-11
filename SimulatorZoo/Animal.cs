using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorZoo
{
    class Animal
    {
        public string Name { get; set; }    
        public int Age { get; set; }
        public int Life { get; set; }
        

        public Animal(string Name , int Age , int Life) 
        {
            this.Name= Name;
            this.Age = Age;
            this.Life = Life;
        }

        public void PrimesteDamage(int damage)
        {
            Life -= damage;
            if(Life <= 0 )
            {
                Console.WriteLine("{0} este mort." , Name);
            }

        }

        public void UrmatoareaZi()
        {
            Age++;
            Console.WriteLine("Varsta lui {0} acum este de {1} " , Name , Age);
            Console.WriteLine("Viata {0} acum este de {1} " , Name , Life);

        }

       
       
    }
}
