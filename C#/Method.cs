using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    
    public class Method
    {
        public void getNumbs(params int[] num)
        {
            foreach (int i in num) 
            { 
                Console.WriteLine(i);
            }
        }

        public void updateNum(ref int a)
        {
            a++;
        }

        public void giveNum(out int a)
        {
            a = 2;
        }

        
    }
}
