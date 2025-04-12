using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1console
{
    public class Warehouse
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public string GetInventoryReport()
        {
            StringBuilder report = new StringBuilder();
            foreach (var product in products)
            {
                report.AppendLine(product.ToString());
            }
            return report.ToString();
        }
    }
}