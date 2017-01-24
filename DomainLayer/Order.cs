using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainLayer
{
    public class Order
    {
        DateTime orderDate;
        DateTime deliveryDate;
        int orderID;
        List<OrderLine> OrderLines = new List<OrderLine>();
        
        public Order(DateTime _orderDate, DateTime _deliveryDate)
        {
            orderDate = _orderDate;
            deliveryDate = _deliveryDate;
            ;

        }
        
        public override string ToString()
        {
            return "OrderID: " + orderID + ", Orderdate: " + orderDate.Year + "-"+ orderDate.Month + "-"+ orderDate.Day + 
                ", Deliverydate: " + deliveryDate.Year + "-" + deliveryDate.Month + "-" + deliveryDate.Day;
        }

        public void AddOrderLine(OrderLine orderLine)
        {
            OrderLines.Add(orderLine);
        }

        public void SetId(int id)
        {
            orderID = id;
        }
    }
}
