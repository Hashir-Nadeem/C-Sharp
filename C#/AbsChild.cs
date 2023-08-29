using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class AbsChild : Abstract,ICarFunction
    {
        public void Beep()
        {
            Console.WriteLine("Beep");
        }

        public void Boop()
        {
            Console.WriteLine("Boop");
        }

        public override void printErr(string err)
        {
            Console.WriteLine("Print Err From Child"+err);
        }
    }
}
