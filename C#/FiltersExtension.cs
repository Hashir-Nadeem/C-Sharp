using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public static class FiltersExtension
    {
        public static void extendedMethod(this Filters filter)
        {
            Console.WriteLine("Extended Filter");
        }
    }
}
