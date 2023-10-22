using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEvents
{
    public class Order
    {
        public event EventHandler<OrderEventArgs> OnCreated;

        public void Create(string email, string phone) {
            Console.WriteLine("Order Created");
            if (OnCreated != null) {
                OnCreated(this, new OrderEventArgs { Email = email, Phone = phone });
            }
        }
    }
}
