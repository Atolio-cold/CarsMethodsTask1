﻿using System;

namespace CarsMethodsTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ToyotaCorolla = new Car("Toyota", "Corolla");

            ToyotaCorolla.SetYear(new DateTime(2023, 1, 1));
            ToyotaCorolla.DescribeCar();

            Car MercedesBenz = new Car(1990, "Mercedes", "Benz");
            MercedesBenz.DescribeCar();

        }
    }
}

