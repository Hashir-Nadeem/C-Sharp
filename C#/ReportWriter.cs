using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class ReportWriter
    {
        public delegate void NotificationHub(object soruce,EventArgs e);
        public event NotificationHub OnNotificationHub;
        public void writeReport()
        {
            Console.WriteLine("Report Has Been Written");
            OnNotificationHub(this,EventArgs.Empty);
        }
    }
}
