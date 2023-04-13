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
        private Leu leu1 { get; set; }
        private Tigri tigru1 { get; set; }
        public  Zoo(Maimuta maimuta , Leu leu , Tigri tigru)
        {
         
            this.maimuta1 = maimuta;
            this.leu1 = leu;
            this.tigru1 = tigru;
            

        }

        
        

        public void Run()
        {
            Console.WriteLine("Buna ziua , bine ati venit la gradina noastra ZOO!");
            Console.WriteLine("\n");
            Console.WriteLine("In gradina avem o maimuta pe nume {0} , un leu pe nume {1} , un tigru pe nume ", maimuta1.Name , leu1.Name , tigru1.Name);
            Console.WriteLine("\n");
            

            int zile = 1;
            //while true este folosit pentru a mima rularea continua a programului 
            //el se opreste la primul break dat de noi in momentul in care consideram ca trebuie oprit programul.
            while (true)
            {
                string input;
                Console.WriteLine("Este ziua : {0}", zile);
                AfisareStatus();
                Console.WriteLine("Ce animal ati dori sa hraniti? \n");
                Console.WriteLine("Pentru maimuta introduceti 1.");
                Console.WriteLine("Pentru leu introduceti 2.");
                Console.WriteLine("Pentru tigru introduceti 3 \n");
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
                        case 2 :
                            {
                                Console.WriteLine("Leul a fost hranit.");
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Tigru a fost hranit.");
                                break;
                            } 
                        default:
                            {
                                Console.WriteLine("Nu este o optiune valida!");
                                break;
                            }

                            
                    }
                    leu1.UrmatoareaZi();
                    leu1.MoarteLeu();
                    maimuta1.UrmatoareaZi();
                    maimuta1.MoarteMaimuta();
                    tigru1.UrmatoareaZi();
                    tigru1.MoarteTigri();

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
            Console.WriteLine("Maimuta de rasa {0},pe nume {1}, are varsta de {2} zile." ,maimuta1.Rasa , maimuta1.Name , maimuta1.Age);
            Console.WriteLine("Leul de sex {0} , pe nume {1} , are varsta de {2} zile." , leu1.Sexul , leu1.Name , leu1.Age);
            Console.WriteLine("Tigru de culoare {0} , pe nume {1} , are varsta de {2} zile." , tigru1.Culoarea , tigru1.Name , tigru1.Age);

        }
        
        


    }
}
