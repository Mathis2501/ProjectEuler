using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    public class Product
    {
        //Variables
        static int nextid = 1;

        int productId;
        string productName;
        double price;
        string description;
        int amount;
        //Properties
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        //Constructor
        public Product()
        {

        }
        public Product(string productName, double price, string description, int amount)
        {
            this.productName = productName;
            this.price = price;
            this.description = description;
            this.amount = amount;
            productId = nextid++;
        }
        //Methods
        public int GetId()
        {
            return productId;
        }
        public override string ToString()
        {
            return productId + ", " + productName + ", " + price + ", " + description + ", " + amount;
        }
        public void AddToAmount(int addAmount)
        {
            amount += addAmount;
        }
        public void SubFromAmount(int subAmount)
        {
            if (amount > subAmount)
            {
                amount -= subAmount;
            }
            else
            {
                Console.WriteLine("There is not enough in stock to process this order.");
            }
        }
        public void AdjustPrice(double adjustedPrice)
        {
            price = adjustedPrice;
        }

        
    }
}
