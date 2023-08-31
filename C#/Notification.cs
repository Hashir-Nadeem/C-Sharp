using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Notification
    {
        public void sendEmail(object source,EventArgs e)
        {
            Console.WriteLine("Report Has Been Send");
        }
    }
}
