using System;

namespace Constructors
{
    public class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initiliazed.");
        }
    }

    public class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car is being initiliazed.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
