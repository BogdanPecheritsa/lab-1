using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1console
{
    public class Reporting
    {
        private Warehouse warehouse;

        public Reporting(Warehouse warehouse)
        {
            this.warehouse = warehouse;
        }

        public void PrintReport()
        {
            Console.WriteLine("Звіт про інвентаризацію:");
            Console.WriteLine(warehouse.GetInventoryReport());
        }
    }
}