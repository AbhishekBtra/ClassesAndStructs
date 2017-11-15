using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesNStructs
{
    class ValueTypeEquivalenceClass
    {

        int num;
        int num1;

        public ValueTypeEquivalenceClass()
        {
            num = 5;
            num1 = 10;
        }

        public void CheckValueTypesEquivalence()
        {
            // using ReferenceEquals
            //for value types ReferenceEqual will always return false
            //coz the value types are boxed first and then compared.
           
            if (String.ReferenceEquals(num, num1))  
               Console.WriteLine("Referecnce of ints num & num1 is equal s1(hashcode = {0}) and s2(hashcode = {1} \n)", num.GetHashCode(), num1.GetHashCode());
           
            else
                Console.WriteLine("Referecnce of ints num & num1 is not equal s1(hashcode = {0}) and s3(hashcode = {1})", num.GetHashCode(), num1.GetHashCode());

        }
    }
}
