using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorZoo
{
    public  class Zoo
    {
        private Maimuta maimuta1 { get; set; }
        public  Zoo(Maimuta maimuta) 
        {
            this.maimuta1 = maimuta;
            

        }

        public void Run()
        {
            Console.WriteLine("Buna ziua , bine ati venit la gradina noastra ZOO!");
            Console.WriteLine("In gradina avem o maimuta pe nume {0}", maimuta1.Name);

            int zile = 1;
            //while true este folosit pentru a mima rularea continua a programului 
            //el se opreste la primul break dat de noi in momentul in care consideram ca trebuie oprit programul.
            while (true)
            {
                string input;
                Console.WriteLine("Este ziua : {0}", zile);
                AfisareStatus();
                Console.WriteLine("Ce animal ati dori sa hraniti?");
                Console.WriteLine("Pentru maimuta introduceti 1.");
                input= Console.ReadLine();
                int optiune;
                if(input != null && int.TryParse(input , out optiune)) 
                {
                    switch (optiune)
                    {
                        case 1 :
                            {
                                
                                Console.WriteLine("Maimuta s-a hranit.");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Nu este o optiune valida!");
                                break;
                            }

                            
                    }

                }
                else
                {
                    Console.WriteLine("La revedere , nu este bine ce ati introdus.");
                    break;
                }
                //Trecem la finalul fiecarei zile se incrementeaza ziua.
                zile++;
                

            }
        }

        public void AfisareStatus()
        {
            Console.WriteLine("Maimuta de rasa {0},pe nume {2}, are varsta de {1} zile." ,maimuta1.Rasa , maimuta1.Name , maimuta1.Age);

        }
        
        


    }
}
