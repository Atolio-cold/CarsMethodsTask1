using System;
using System.Dynamic;

namespace Coding.Exercise
{

    public abstract class Vehicle
    {
        public string Model { get; set; }
        public abstract void Start();
        public abstract void Stop();
    }

    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine($"Starting the car: {Model}");
        }
        public override void Stop()
        {
            Console.WriteLine($"Stopping the car: {Model}");
        }

    }


    public class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine($"Starting the motorcycle: {Model}");
        }
        public override void Stop()
        {
            Console.WriteLine($"Stopping the motorcycle: {Model}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie obiektu klasy Car
            Car car = new Car { Model = "Toyota Corolla" };
            car.Start();
            car.Stop();

            // Tworzenie obiektu klasy Motorcycle
            Motorcycle motorcycle = new Motorcycle { Model = "Harley Davidson" };
            motorcycle.Start();
            motorcycle.Stop();
        }
    }

}
