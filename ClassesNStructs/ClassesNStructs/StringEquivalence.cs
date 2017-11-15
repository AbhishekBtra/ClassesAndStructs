using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesNStructs
{
    class StringEquivalence
    {
        public String s1 = "String";
        public String s2 = "String";

        public void CheckStringEquality()
        {
            string s3 = "abc";
            if (String.IsInterned(s1) != null) // interned strings are managed by CLR, strings are interned if they are IDENTICAL
            {
                if (s1.Equals(s2))
                    Console.WriteLine("Equal String");
                else
                    Console.WriteLine("NOt Equal String");
            }
            else { Console.WriteLine("NOt Interned String"); }

            string s4 = s1 + s3;
            string s5 = s1 + s3;
            if (String.IsInterned(s4) != null || String.IsInterned(s5) != null) // interned strings are
            //managed by CLR, string s4 and s5 are identical but they are NOT INTERNED. 
            {
                if (s4.Equals(s5))
                    Console.WriteLine("Equal String");
                else
                    Console.WriteLine("NOt Equal String");
            }
            else { Console.WriteLine("NOt Interned String"); }
            /*String is Interned - 
            The common language runtime automatically maintains a table, 
            called the intern pool, which contains a 
            "single instance(reference) of each unique literal 
            string constant declared in a program", 
            as well as any unique instance of String
            you add programmatically by calling the Intern method.*/



        }

        public void CheckRefernceEquivalence()
        {
            string s1 = "abc";
            string s2 = "abc";
            string s3 = "abcd";
            if (String.ReferenceEquals(s1,s2))  // ReferenceEquals is a static function, which makes sure that if a class has implemented its own copy of Equal func 
                    //then we can use ReferenceEquals instead as it returns true if reference are same else false and cannot be overidden by class.
                Console.WriteLine("Referecnce of strings s1 & s2 is equal s1(hashcode = {0}) and s2(hashcode = {1})",s1.GetHashCode(),s2.GetHashCode());
            if (String.ReferenceEquals(s1, s3))
                Console.WriteLine("Referecnce of strings s1 & s2 is equal s1(hashcode = {0}) and s2(hashcode = {1})", s1.GetHashCode(), s2.GetHashCode());
            else
                Console.WriteLine("Referecnce of strings s1 & s2 is not equal s1(hashcode = {0}) and s3(hashcode = {1})", s1.GetHashCode(), s3.GetHashCode());
        }
    }
}
