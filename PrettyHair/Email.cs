using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyHair
{
    public class Email //Listener
    {
        public void Subscribe(OrderRepository o)
        {
            o.Email += new OrderRepository.EmailHandler(OrderReady);

        }
        private void OrderReady(OrderRepository o, EventArgs e)
        {
            Console.WriteLine("Email sent.");
            Console.ReadKey();
        }
    }
}
