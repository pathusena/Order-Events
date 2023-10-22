using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEvents
{
    public class Email
    {
        public static void Send(object sender, OrderEventArgs e) {
            Console.WriteLine($"Sending an email to {e.Email}");
        }
    }
}
