using System;

namespace References_Morgan_Daniel
{
    class Program
    {/// <summary>
    /// Created two new Sedan object with an assigned IAutomobile object, with the speed of the sedan and IAutomobile object, and a comparision of thhem is printed to the console
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Sedan myFirstSedan = new Sedan(0);
            IAutomobile myAutomobile = myFirstSedan;

            Sedan myOtherSedan = new Sedan(0);

            myFirstSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

            myOtherSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myOtherSedan.Speed);
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

            Truck MyTruck = new Truck(50, 500, "MyTrUck");

            myFirstSedan.Stringify();
            myAutomobile.Stringify();
            myOtherSedan.Stringify();
            MyTruck.Stringify();
        }
    }
}
