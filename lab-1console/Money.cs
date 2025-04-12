using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1console
{
    public class Money
    {
        public int Dollars { get; private set; }
        public int Cents { get; private set; }

        public Money(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
        }

        public override string ToString()
        {
            return $"{Dollars} доларів і {Cents} центів";
        }

        public void SetValue(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
        }
    }
}