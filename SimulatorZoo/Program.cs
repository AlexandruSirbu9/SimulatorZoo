namespace SimulatorZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Maimuta maimuta = new Maimuta("Ali" , 24 , "Capucino");
            Zoo zoo = new Zoo(maimuta);
            zoo.Run();
            


            
        }
    }
}