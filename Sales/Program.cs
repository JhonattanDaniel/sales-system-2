using System;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            SalesMan seller1 = new SalesMan();
            seller1.Name = "Arturo Rojas";
            seller1.Age = 45;
            company.AddSalesMan(seller1);

            SalesMan seller2 = new SalesMan();
            seller2.Name = "Adriana Zuluaga";
            seller2.Age = 38;
            company.AddSalesMan(seller2);

            SalesMan seller3 = new SalesMan();
            seller3.Name = "Carlos Vallejo";
            seller3.Age = 41;
            company.AddSalesMan(seller3);

            Product p1 = new Product();
            p1.Name = "computer";
            p1.SetPrice(1000);
            company.AddProduct(p1);

            Product p2 = new Product();
            p2.Name = "smartphone";
            p2.SetPrice(600) ;
            company.AddProduct(p2);

            Product p3 = new Product();
            p3.Name = "smart tv";
            p3.SetPrice(900);
            company.AddProduct(p3);

            Sale s1 = new Sale();
            s1.Product = p2;
            s1.SalesMan = seller1;
            s1.Comments = "Arturo sold a smartphone";
            company.AddSale(s1);

            Sale s2 = new Sale();
            s2.Product = p3;
            s2.SalesMan = seller2;
            s2.Comments = "Adriana sold a smart tv";
            company.AddSale(s2);

            Sale s3 = new Sale();
            s3.Product = p1;
            s3.SalesMan = seller3;
            s3.Comments = "Carlos sold a computer";
            company.AddSale(s3);

            string CheapestSale = company.CheapestSale().Name;
            string ExpensiveProduct = company.ExpensiveProduct().Name;
            double ProductsAverage = company.ProductsAverage();
            int SalesUnits = company.SalesUnits();
            double salesTotal = s1.Product.GetPrice() + s2.Product.GetPrice() + s3.Product.GetPrice();

            System.Console.WriteLine("Sales total acound US$ " + salesTotal);
            System.Console.WriteLine("the seller who made the cheapest sale is " + CheapestSale);
            System.Console.WriteLine("the most expensive product " + ExpensiveProduct);
            System.Console.WriteLine("Products price average US$ " + ProductsAverage);
            System.Console.WriteLine("the units that have been sold are " + SalesUnits);
        }
    }
}
