using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStruct
{
    struct Car
    {
        public string Make;
        public string Model;
        public string Color;

        public void Accelerate()
        {
            Console.WriteLine("Vroom");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Yaris";
            myCar.Color = "Silver";
            Console.WriteLine($"My car is a {myCar.Make} {myCar.Model} that is {myCar.Color} in color.");
            Console.WriteLine();
            myCar.Accelerate();
            Console.ReadLine();
        }
    }
}
