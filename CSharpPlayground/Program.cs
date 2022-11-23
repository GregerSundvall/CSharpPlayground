using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




// Trying out .net object allocation tracking



namespace CSharpPlayground
{

    struct Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
    }

    class Driver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Car Car { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var contestantsMaxCount = 10;
            var NameOfRace = "Vagnhärads Grand Prix";
            var contestants = new List<Driver>();

            var driver1 = new Driver() { Name = "Åke Vilse", Age = 89 };
            driver1.Car = new Car() {Model = "Lada Niva", Year = 1980 };
            contestants.Add(driver1);
            
            var driver2 = new Driver() { Name = "Inge Vidare", Age = 20 };
            driver2.Car = new Car() {Model = "Opel Kadett", Year = 1990 };
            contestants.Add(driver2);

            var driver3 = new Driver() { Name = "Sten Hög", Age = 33 };
            var driver3Car = new Car() {Model = "Lambo Gallardo", Year = 2012 };
            driver3.Car = driver3Car;
            contestants.Add(driver3);
            

            var foundHim = false;
            foreach (Driver driver in contestants)
            {
                if (driver.Name == "Inge Vidare") 
                { 
                    contestants.Remove(driver);
                    foundHim = true;
                    return;
                }
            }
            Console.WriteLine(foundHim? "Gone" : "No findy");
            




        }
    }
}
