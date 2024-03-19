using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPE2100_Dumol_Prelim2
{
    class Transaction
    {
        public int[] itemPrice = new int[5] { 0, 0, 0, 0, 0 };
        public string[] itemName = new string[5] { "", "", "", "", "" };
        public string CustomerName { get; set; }
        public string CashierName { get; set; }
        public int TotalPrice { get; set; }
        public int RemainingAmount { get; set; }

    }
}