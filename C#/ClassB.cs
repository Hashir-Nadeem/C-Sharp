using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class ClassB:ClassA
    {
        public int id { get; set; }
        public ClassB()
        {
            Console.WriteLine("Derived Constructor Called");
        }
        //calling base class parameterized constructor
        public ClassB(int id):base(id)
        {
            Console.WriteLine("Derived Parameterized Called");
        }

        //calling base class function
        public void printB()
        {
            base.printA();
            Console.WriteLine("PrintB");
        }

        public override void partial()
        {
            Console.WriteLine("Partial Print of B");
        }
    }
}
