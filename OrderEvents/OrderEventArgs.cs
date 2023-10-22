using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEvents
{
    public class OrderEventArgs:EventArgs
    {
        public String Email { get; set; }
        public String Phone { get; set;}
    }
}
