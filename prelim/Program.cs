using System;

namespace POSSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();

            Console.Write("How many items?: ");
            int numberOfItems = int.Parse(Console.ReadLine());

            if (numberOfItems < 3)
            {
                Console.WriteLine("Too few items");
                Console.ReadLine();

            }
            else if (numberOfItems > 5)
            {
                Console.WriteLine("Too many items");
                Console.ReadLine();
            }

            var items = new Item[numberOfItems];
            for (int i = 0; i < numberOfItems; i++)
            {
                Console.Write("Enter item: ");
                string itemName = Console.ReadLine();

                Console.Write("Enter price of item: ");
                double itemPrice = double.Parse(Console.ReadLine());

                items[i] = new Item(itemName, itemPrice);
            }

            var transaction = new Transaction(customerName, items);

            Console.Write("Choose payment method (Cash/Card): ");
            string paymentMethod = Console.ReadLine().ToLower();

            if (paymentMethod == "card")
            {
                Console.Write("Enter card number: ");
                string cardNumber = Console.ReadLine();

                Console.Write("Enter card balance: ");
                double balance = double.Parse(Console.ReadLine());

                if (balance >= transaction.GetToBePaid())
                {
                    transaction.PayAmount(transaction.GetToBePaid());
                    double change = balance - transaction.GetToBePaid();
                    Console.WriteLine("change: {0}", change);
                }
                else
                {
                    Console.WriteLine("Not enough balance");
                    Console.WriteLine("Would you like to pay through cash instead(1) or pay with both(2): ");
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "1")
                    {
                        double payment;
                        Console.Write("Enter payment amount: ");
                        payment = double.Parse(Console.ReadLine());
                        transaction.PayAmount(payment);
                    }
                    else if (choice == "2")
                    {
                        double payment;
                        transaction.PayAmount(balance);
                        Console.Write("Enter cash amount: ");
                        payment = double.Parse(Console.ReadLine());
                        transaction.PayAmount(payment);
                    }
                }
            }
            else if (paymentMethod == "cash")
            {
                double payment;
                Console.Write("Enter payment amount: ");
                payment = double.Parse(Console.ReadLine());
                transaction.PayAmount(payment);
            }

            Console.WriteLine("Cashier for this transaction is {0}", transaction.GetCashierName());
            Console.WriteLine("Customer for this transaction is {0}", transaction.GetCustomerName());
            foreach (var item in items)
            {
                Console.WriteLine("{0}: Php {1}", item.Name, item.Price);
            }
            Console.WriteLine("Amount to be paid is {0}", transaction.GetToBePaid());
            Console.WriteLine("Amount paid is {0}", transaction.GetAmountPaid());
            Console.WriteLine("Remaining balance/change is {0}", transaction.GetRemainingBalance());

            Console.ReadLine();
        }
    }
}