using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1console
{
    class Program
    {
        static void Main(string[] args)
        {
            Money price = new Money(10, 50);

            Product apples = new Product("Яблука", price, 100);

            Warehouse warehouse = new Warehouse();
            warehouse.AddProduct(apples);

            Reporting reporting = new Reporting(warehouse);

            reporting.PrintReport();

            apples.ApplyDiscount(20);

            Console.WriteLine("Після знижки:");
            reporting.PrintReport();

            Console.WriteLine("Натисність будь-яку клавішу для виходу.");
            Console.ReadKey();
        }
    }
}