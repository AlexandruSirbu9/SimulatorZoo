namespace SimulatorZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Maimuta maimuta = new Maimuta("Raluca" , 22 , 100 , "Capucino");
            maimuta.PrimesteDamage(20);
            maimuta.UrmatoareaZi();

            maimuta.PrimesteDamage(30);
            maimuta.UrmatoareaZi();

            Console.ReadKey();
            


            
        }
    }
}