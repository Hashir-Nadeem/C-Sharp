using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    /*Constructor human = new Constructor() {_id=2}; object initializer */
    public class Constructor
    {
        public int _id;

        //constuctor overloading
        public Constructor()
        {
                _id = 0;
        }

        //this() is used to call base constructor first then this
        public Constructor(int id):this()
        {
            _id = id;
        }

        //this(id) will call constructor with one parameter id
        public Constructor(int id, string name):this(id)
        {
          
        }
        
        //copy constrcutor
        public Constructor(Constructor human1)
        {
            this._id=human1._id;
        }

        //static constructor which dont have any access modifiers also dont take paramters
        static Constructor()
        {

        }

        /*private constructor is the one that make this class away from inheritance and object creation and
        cannot have other default or paramterless constructor once we define private constructor*/

        /*private Human()
        {

        }*/
        
    }
}
