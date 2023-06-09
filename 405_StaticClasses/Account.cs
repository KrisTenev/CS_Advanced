using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405_StaticClasses
{
    class Account
    {
        public string Owner { get; set; }
        public decimal Balance { get; set; }
        public static decimal Tax { get; set; }

        public void PayTax()
        {
            this.Balance -= Tax;
        }

        public static string GetBankName()
        {
            return "UBB";
        }
    }
}
