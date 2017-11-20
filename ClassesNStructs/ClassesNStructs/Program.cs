using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesNStructs
{

    class Program
    {

        struct Numbers  //Structs are value type
        {
            public int n;  // No valriable initialization inside Struct

            public Numbers(int p)  //Only param Constructor allowed
            {
                n = p;
            }

        }

        public void CheckStructEquality()
        {
            #region StructsAreValueTypes
            Numbers ob = new Numbers(10);
            Numbers ob1 = ob; // Copying ob to ob1
            ob1.n = 20;
            Console.WriteLine("This is N {0}", ob.n);  //10
            Console.WriteLine("This is N {0}", ob1.n); //20 Cause obj1 and obj are refering to DIFFERENT copies of n.

            //Now Reference type ie class 
            CNumbers obj = new CNumbers(15);
            CNumbers obj1 = obj;  //Obj1 refers to obj
            obj1.n = 40;
            Console.WriteLine("This is N {0}", obj.n); //40
            Console.WriteLine("This is N {0}", obj1.n); //40 Cause obj1 and obj are refering to same n.

            //Instantiating a struct w/o new operator
            Numbers object3;
            object3.n = 36;
            Console.WriteLine("This is N {0}", object3.n); //36 
            #endregion

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            //p.CheckStructEquality();
            StringEquivalence s = new StringEquivalence();
            //s.CheckStringEquality();
            //s.CheckRefernceEquivalence();
            ValueTypeEquivalenceClass ob = new ValueTypeEquivalenceClass();
            //ob.CheckValueTypesEquivalence();
            DerivedClass obj = new DerivedClass();
            BaseClass bobj = new BaseClass();

            //obj = (DerivedClass)bobj;//Runtime Error - no compile time error cause of explicit casting
            Console.WriteLine("Derived class vol = {0}", obj.CalcVolume(5));
            Console.WriteLine("Base class vol = {0}", bobj.CalcVolume(10));
            Console.WriteLine("Derived class area = {0}", obj.CalArea());
            Console.WriteLine("Base class area = {0}", bobj.CalArea());
            bobj = (BaseClass)obj;
            Console.WriteLine("WITH VIRTUAL FEATURE -START\n");
            Console.WriteLine("Derived class vol = {0}", obj.CalcVolume(5));
            Console.WriteLine("Base class vol = {0}", bobj.CalcVolume(10));
            Console.WriteLine("WITH VIRTUAL FEATURE -END\n");
            Console.WriteLine("WITHout NEW FEATURE -START\n");
            Console.WriteLine("Derived class area = {0}", obj.CalArea());
            Console.WriteLine("Base class area = {0}", bobj.CalArea());
            Console.WriteLine("WITHout NEW FEATURE -END\n");
            int area2 = obj.CalArea2();
             Console.WriteLine("Derived class area2 = {0}", obj.CalArea2());
            Console.WriteLine("Base class area2 = {0}", bobj.CalArea2());

            Console.ReadKey();
        }
    }

    
    
}
