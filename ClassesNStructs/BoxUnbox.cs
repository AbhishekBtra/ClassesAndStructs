using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesNStructs
{
    class BoxUnbox
    {

        public void BoxSomething()
        {
            int i = 123;
            object o = i;
            i = 456;

            Console.WriteLine("O type is {0} O basetype is {3}  i = {1} & o = {2}", o.GetType(),i,o, o.GetType().BaseType); //prints Int32 , 456 123 
            //Coz  boxing allocates a the memory for o in heap and now o has a copy of value of i.


            
           
            

        }
    }
}
