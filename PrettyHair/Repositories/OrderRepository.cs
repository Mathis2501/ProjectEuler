using System;
using System.Collections.Generic;
using System.Linq;
using PrettyHair.Repositories;

namespace PrettyHair.Repositories
{
    public class OrderRepository
    {
        ProductRepository prodRepo = new ProductRepository();
        List<DomainLayer.Order> orderList = new List<DomainLayer.Order>();
        List<string> stringList = new List<string>();
        

        public void AddOrderToList(DomainLayer.Order newOrder)
        {
            newOrder.SetId(this.OrderIDGen());
            orderList.Add(newOrder);
        }
        public List<DomainLayer.Order> GetList()
        {
            return orderList;
        }
        public List<string> GetListAsStringList()
        {
            foreach (DomainLayer.Order order in orderList)
            {
                stringList.Add(order.ToString());
            }

            return stringList;
        }

        public int OrderIDGen()
        {
            return orderList.Count();
        }

        public event EmailHandler Email;
        public EventArgs e = null;
        public delegate void EmailHandler(OrderRepository o, EventArgs e);

        //public void CheckQuantityAgainstAmount() 
        //{
        //    List<Product> prodList = prodRepo.GetList();

        //    foreach (Order order in orderList)
        //    {
        //        foreach (Product item in prodList)
        //        {
        //            if (order.ProductTypeId == item.GetId())
        //            {
        //                if (order.Quantity <= item.Amount)
        //                {
        //                    if (Email != null)
        //                    {
        //                        Email(this, e);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
