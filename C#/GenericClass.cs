using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class GenericClass<T>
    {
        T[]arr=new T[10];
        int i=0;
        public GenericClass() { Console.WriteLine("Generic Class"); }   

        public void add(T item)
        {
            arr[i] = item;
            i++;
        }

        public void print()
        {
            Console.WriteLine(arr.GetType().ToString());
        }
    }
}
