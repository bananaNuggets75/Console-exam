using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPE2100_Dumol_Prelim2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cusName, item, cashName, payOpt, cardNum;
            int price, itemNum, totalPrice = 0, credBal = 0, cashAmt = 0, remAmt = 0;
            Transaction trnsc1 = new Transaction();

            Console.WriteLine("Enter Cashier Name: ");
            cashName = Console.ReadLine();
            trnsc1.CashierName = cashName;
            Console.WriteLine("Enter Customer Name: ");
            cusName = Console.ReadLine();
            trnsc1.CustomerName = cusName;
            Console.WriteLine("Enter Number of Items (up to 5 items): ");
            itemNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < itemNum; i++)
            {
                Console.WriteLine("Enter Item Name: ");
                item = Console.ReadLine();
                trnsc1.itemName[i] = item;
                Console.WriteLine("Enter Item Price: ");
                price = int.Parse(Console.ReadLine());
                trnsc1.itemPrice[i] = price;
                totalPrice += price;
            }
            trnsc1.TotalPrice = totalPrice;
            Console.WriteLine("Total Price is {0}", trnsc1.TotalPrice);
            Console.WriteLine("Payment Option (1 - Card, 2 - Cash): ");
            payOpt = Console.ReadLine();

            if (payOpt == "1")
            {
                Console.WriteLine("Please Enter Card Number: ");
                cardNum = Console.ReadLine();
                Console.WriteLine("Please Enter Card Balance: ");
                credBal = int.Parse(Console.ReadLine());
                if (credBal < totalPrice)
                {
                    Console.WriteLine("Insufficient Balance. Please Choose to payment option (1 - Pay Remaining Balance, 2 - Pay in Cash): ", totalPrice - credBal);
                    payOpt = Console.ReadLine();
                    if (payOpt == "1")
                    {
                        Console.WriteLine("Remaining Balance to pay is {0}. Please Enter Cash:", totalPrice - credBal);
                        cashAmt = int.Parse(Console.ReadLine());
                    }
                }
                remAmt = (credBal + cashAmt) - trnsc1.TotalPrice;
            }
            if (payOpt == "2")
            {
                Console.WriteLine("Please Enter Cash: ");
                cashAmt = int.Parse(Console.ReadLine());
                remAmt = cashAmt - trnsc1.TotalPrice;
            }
            trnsc1.RemainingAmount = remAmt;

            Console.WriteLine("Cashier Name: {0}", trnsc1.CashierName);
            Console.WriteLine("Customer Name: {0}", trnsc1.CustomerName);
            for (int i = 0; i < itemNum; i++)
            {
                Console.WriteLine("Item: {0}, Price: {1}", trnsc1.itemName[i], trnsc1.itemPrice[i]);
            }
            Console.WriteLine("Total Amount to be Paid: {0}", trnsc1.TotalPrice);
            Console.WriteLine("Amount Paid: {0}", credBal + cashAmt);
            Console.WriteLine("Remaining Amount to be Rendered: {0}", trnsc1.RemainingAmount);
            Console.ReadLine();
        }
    }
}