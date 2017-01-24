using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainLayer
{
    public class OrderLine
    {
        int orderID;
        int amount;
        int productID;
        int productPrice;

        public OrderLine(int _orderID, int _amount, int _productID, int _productPrice)
        {
            orderID = _orderID;
            amount = _amount;
            productID = _productID;
            productPrice = _productPrice;
        }
    }
}
