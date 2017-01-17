using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    public class Order
    {
        DateTime orderDate;
        DateTime deliveryDate;
        int productTypeId;
        int quantity;

        public int ProductTypeId
        {
            get { return productTypeId; }
        }
        public int Quantity
        {
            get { return quantity; }
        }

        public Order(DateTime _orderDate, DateTime _deliveryDate, int _quantity, int _productTypeId)
        {
            orderDate = _orderDate;
            deliveryDate = _deliveryDate;
            quantity = _quantity;
            productTypeId = _productTypeId;
            
        }
        
        public override string ToString()
        {
            return "ID: " + productTypeId + ", Quantity: " + quantity + 
                ", Orderdate: " + orderDate.Year + "-"+ orderDate.Month + "-"+ orderDate.Day + 
                ", Deliverydate: " + deliveryDate.Year + "-" + deliveryDate.Month + "-" + deliveryDate.Day;
        }
    }
}
