using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Product
    {
        private double price;
        private int amount;
        private string name;
        
        public Product(string name, double priceAtStart, int amountAtStart)
        {
            this.name = name;
            amount = amountAtStart;
            price = priceAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{name}, price {price}, amount {amount}");
        }

        public void ChangeAmount(int amount)
        {
            this.amount = amount; ;
        }

        public void ChangePrice(double price)
        {
            this.price = price;
        }

    }
}

