using System;
using System.Collections.Generic;
using System.Text;

namespace Sales
{
    class Company
    {
        SalesMan[] Sellers = new SalesMan[10];
        int sellersCount = 0;

        Product[] Products = new Product[5];
        int productCount = 0;

        Sale[] Sales = new Sale[10* 5];
        int salesCount = 0;

        public void AddSalesMan(SalesMan newSalesMan)
        {
            Sellers[sellersCount] = newSalesMan;
            sellersCount++;
        }

        public void AddProduct(Product newProduct)
        {
            Products[productCount] = newProduct;
            productCount++;
        }
        public void AddSale(Sale newSale)
        {
            Sales[salesCount] = newSale;
            salesCount++;
        }

        public SalesMan CheapestSale()
        {
            Sale CheapestProduct = Sales[0];

            for (int i = 0; i < salesCount; i++)
            {
                if(Sales[i].Product.GetPrice() < CheapestProduct.Product.GetPrice())
                {
                    CheapestProduct = Sales[i];
                }
            }
            return CheapestProduct.SalesMan;
        }
        public Product ExpensiveProduct()
        {
            Sale CheapestProduct = Sales[0];

            for (int i = 0; i < salesCount; i++)
            {
                if (Sales[i].Product.GetPrice() > CheapestProduct.Product.GetPrice())
                {
                    CheapestProduct = Sales[i];
                }
            }
            return CheapestProduct.Product;
        }

        public double ProductsAverage()
        {
            double SumsProducts = 0;

            for (int i = 0; i < productCount; i++)
            {
                SumsProducts = SumsProducts + Products[i].GetPrice();
            }

            return SumsProducts/productCount;
        }
        public int SalesUnits()
        {
            int count = 0;

            for(int i = 0; i < salesCount; i++)
            {
                count++;
            }
            return count;
        }
    }

}
