using System;
using System.Collections.Generic;
using System.Text;

namespace Sales
{
    class Product
    {
        public string Name;
        private double Price;

        public void SetPrice(double newPrice)
        {
            if (newPrice > 0)
            {
                Price = newPrice;
            }
            else
            {
                Console.WriteLine("the price of " + Name + " must be greater than zero");
            }
        }

        public double GetPrice()
        {
            return Price;
        }
    }
}
