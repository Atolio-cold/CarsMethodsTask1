using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CarsMethodsTask1
{
    class Car
    {
        public string Brand;
        public string Model;
        private int Year;
        private string idnumber;

        public string IdNumber
        {
            get { return idnumber; }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Invalid id number");
                }
                else
                {
                    idnumber = value;
                }
            }
        }

        public Car(string brand, string model)
        {
            Console.WriteLine("First constructor...");
            this.Brand = brand;
            this.Model = model;
        }

        public Car(int year, string brand, string model) : this(brand, model)
        {
            Console.WriteLine("Second constructor...");
            SetYear(new DateTime(year, 1, 1));
        }

        public void SetYear(DateTime year)
        {
            if (year.Year > DateTime.Now.Year)
            {
                Console.WriteLine("Invalid year");
            }
            else
            {
                Year = year.Year;
            }
        }
        public void DescribeCar()
        {
            if (string.IsNullOrEmpty(Brand) || string.IsNullOrEmpty(Model) || Year == 0)
            {
                Console.WriteLine("Car details are incomplete.");
            }
            else
            {
                Console.WriteLine($"This is a {Brand} {Model} from {Year}.");
            }
        }
    }
}