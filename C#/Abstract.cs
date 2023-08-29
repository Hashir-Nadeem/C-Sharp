using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public abstract class Abstract
    {
        public void printAbs()
        {
            Console.WriteLine("Abstract");
        }
        public static void printStatic()
        {
            Console.WriteLine("Static Member");
        }
        public abstract void printErr(string err);

    }
}
