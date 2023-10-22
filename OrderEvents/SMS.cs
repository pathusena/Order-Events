using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEvents
{
    public class SMS
    {
        public static void Send(object sender, OrderEventArgs e) {
            Console.WriteLine($"Send an SMS to {e.Phone}");
        }
    }
}
