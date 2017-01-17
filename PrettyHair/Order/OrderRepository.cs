using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    public class OrderRepository
    {
        ProductRepository prodRepo = new ProductRepository();
        static List<Order> orderList = new List<Order>();
        List<string> stringList = new List<string>();
        

        public void AddOrderToList(Order newOrder)
        {
            orderList.Add(newOrder);
        }
        public List<Order> GetList()
        {
            return orderList;
        }
        public List<string> GetListAsStringList()
        {
            foreach (Order order in orderList)
            {
                stringList.Add(order.ToString());
            }

            return stringList;
        }

        public event EmailHandler Email;
        public EventArgs e = null;
        public delegate void EmailHandler(OrderRepository o, EventArgs e);

        public void CheckQuantityAgainstAmount() 
        {
            List<Product> prodList = prodRepo.GetList();

            foreach (Order order in orderList)
            {
                foreach (Product item in prodList)
                {
                    if (order.ProductTypeId == item.GetId())
                    {
                        if (order.Quantity <= item.Amount)
                        {
                            if (Email != null)
                            {
                                Email(this, e);
                            }
                        }
                    }
                }
            }
        }
    }
}
