using System;

namespace Constructors
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initiliazed. {0}", registrationNumber);
        }
    }
}
