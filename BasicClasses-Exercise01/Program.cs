using System;

namespace BasicClasses_Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car()
            {
                Make = "Honda",
                Model = "Civic",
                Year = 2011
            };

            Console.WriteLine($"Vehicle make:    {myCar.Make}");
            Console.WriteLine($"Vehicle model:    {myCar.Model}");
            Console.WriteLine($"Vehicle year:    {myCar.Year}");
        }
    }
}
