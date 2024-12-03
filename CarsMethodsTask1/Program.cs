using System;

namespace CarsMethodsTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ToyotaCorolla = new Car();
            ToyotaCorolla.Brand = "Toyota";
            ToyotaCorolla.Model = "Corolla";

            ToyotaCorolla.SetYear(new DateTime(2023, 1, 1));
            ToyotaCorolla.DescribeCar();
        }
    }
}

