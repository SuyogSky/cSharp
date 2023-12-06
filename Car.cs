using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Car
    {
        private string brand;
        private int year;
        private float price;

        public Car(string brand, int year, float price)
        {
            this.brand = brand;
            this.year = year;
            this.price = price;
        }

        public void displayCarInfo()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Price: {price:C}");
        }
    }
}
