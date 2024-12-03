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

        public int GetYear() => Year;

        public void DescribeCar()
        {
            Console.WriteLine($"This is a {Brand} {Model} from {Year}.");
        }

    }
}
