using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class ClassA
    {
        public ClassA() { Console.WriteLine("Base A Constructor Called"); }
        public ClassA(int id)
        {
            Console.WriteLine("Base Parameterized Constructor");
        }
        public void printA()
        {
            Console.WriteLine("Print A");
        }

        public virtual void partial()
        {
            Console.WriteLine("Partial print A");
        }
    }
}
