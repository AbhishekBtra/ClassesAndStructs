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

        public void UnBoxSomething()
        {
            int i = 123;
            object o = i; //boxed  - boxing copies value to the new instance on heap
            i = 456;
            int j = (int) o;  //Unboxed  - Unboxing copies value from the new instance on heap to the variable on stack
                              //in short o has a COPY of i and j has a copy of o. So any changes in i will not be reflected in o and j


           // int k = (short)o; //
            /* No compile error everything is object. So o can be casted to short ONLY AT COMPLIE TIME
            BUT - at runtime CLR verifies  the object instance to meake sure that it is a boxed value of GIVEN value type.
            */
            long l = (long)o;
            /* No compile error everything is object. So o can be casted to LONG ONLY AT COMPLIE TIME
           BUT - at runtime CLR verifies  the object instance to make sure that it is a boxed value of GIVEN value type.
           */




            //short p = (int)o; error cause int cannot be casted to short IMPLICITLY so below i cast it explicitly
            short p = (short)(int)o;

            Console.WriteLine("O type is {0} O basetype is {3}\n  i = {1} & o = {2} \n j = {4}", o.GetType(), i, o, o.GetType().BaseType,j); //prints Int32 , 456 123 
        }
    }
}
