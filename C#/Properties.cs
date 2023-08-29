using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Properties
    {
        private int[] arr=new int[10] {1,2,3,4,5,6,7,8,9,10 };
        private int _id;
        //autoimplemented property
        public string name { get; set; }

        //readonly autoimplemented property
        public string fname { get; private set; }

        //property with separate get set logic if we want to make it readonly so remove set block
        public int id
        {
            get
            {
                if (_id != 0)
                {
                    return _id;
                }
                return 0;
            }
            set
            { 
                _id = value;
            } 
        }

        //indexer
        public int this[int index]
        {
            get
            {
                return this.arr[index]+1;
            }
        }

    }
    }
