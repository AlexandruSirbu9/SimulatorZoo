namespace SimulatorZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Maimuta maimuta = new Maimuta("Ali" , 2 , "Capucino");
            Leu leu = new Leu("Rares", 3, "Barbat");
            Tigri tigru = new Tigri("Ilie", 1, "Galben");
            Zoo zoo = new Zoo(maimuta , leu , tigru);
            zoo.Run();

            
           
            


            
        }
    }
}