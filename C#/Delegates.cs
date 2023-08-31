using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    
    public class Delegates
    {
        //method having same signature this delegate can point to them
        //public delegate void filtersHub();

        public  Filters _filter { get; set; }
        public Delegates(Filters filter)
        {
            _filter = filter;
        }

        /*simple way of calling
        public void processPhoto()
        {
            _filter.brightness();
            _filter.contrast();
            _filter.exposure();
        }*/

        /*Custom delegates
        public void processPhoto(filtersHub filters)
        {
            filters();
        }
        
           //Adding method to delegates make it extensible and flexible
           Delegates.filtersHub filters = () =>
                {
                    Console.WriteLine("Custom Filter");
                };
            filters += () =>
                {
                    Console.WriteLine("Trending Filter");
                };
            del.processPhoto(filters);
         
         */

        //using predefined delegate
        public void processPhoto(Action filters)
        {
            filters();
        }
        /*
        System.Action filters = () =>
        {
            Console.WriteLine("Custom filter");
        };*/


    }
}

