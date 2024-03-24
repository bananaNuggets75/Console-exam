using System;

namespace POSSystem
{
    class Transaction
    {
        private readonly string _cashierName = "Alice";
        private readonly string _customerName;
        private readonly Item[] _items;
        private double _totalToBePaid;
        private double _amountPaid = 0;

        public Transaction(string customerName, Item[] items)
        {
            _customerName = customerName;
            _items = items;
            _totalToBePaid = CalculateTotalToBePaid();
        }

        private double CalculateTotalToBePaid()
        {
            double sum = 0;
            foreach (var item in _items)
            {
                sum += item.Price;
            }
            return sum;
        }

        public void PayAmount(double amount)
        {
            _amountPaid += amount;
        }

        public string GetCashierName() => _cashierName;

        public string GetCustomerName() => _customerName;

        public double GetToBePaid() => _totalToBePaid;

        public double GetAmountPaid() => _amountPaid;

        public double GetRemainingBalance() => _totalToBePaid - _amountPaid;
    }
}