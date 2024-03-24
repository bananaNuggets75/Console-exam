﻿using System;

namespace POSSystem
{
    class Item
    {
        public string Name { get; }
        public double Price { get; }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}