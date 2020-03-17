using System;

namespace ConsoleApp38
{
    class Program
    {

        class Car 
        {
            public string model;
            public Car()
            {
                model = "Passat";
            }

        }
        static void Main(string[] args)
        {
            Car Volkswagen = new Car();
            Console.WriteLine(Volkswagen.model);
        }


    }
}
