

namespace DEV_6
{
    using System;

    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            AutoDatabase newDatabase = new AutoDatabase();
            Console.WriteLine(newDatabase.GetAmountOfAutomobiles());
            Console.WriteLine(newDatabase.GetAmountOfBrands());
            Console.WriteLine(newDatabase.GetAveragePriceOfAllAutomobiles());
            Console.WriteLine(newDatabase.GetAveragePriceOfAllAutomobiles("Nissan"));
        }
    }
}
