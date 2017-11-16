using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesNStructs
{
    class Program
    {
       
        public struct Box
        {
            public int width;
            public int height;
            public int length;

            public Box(int a, int b, int c)
            {
                width = a;
                height = b;
                length = c;

            }
        }
        public void RefEquivalenceCheck()
        {
            BoxClass b1 = new BoxClass(1, 2, 3);
            BoxClass b2 = new BoxClass(1, 2, 3);

            if (b1.Equals(b2))
            {
                Console.WriteLine("Equal \nVolume = {0} ", b1.Volume());
            }
            else
            {

                Console.WriteLine("Not Equal \nVolume = {0} ", b1.Volume());
            }

            

        }

        public void CheckReferenceEqual()
        {
            BoxClass b1 = new BoxClass(1, 2, 3);
            BoxClass b2 = new BoxClass(1, 2, 3);

            if (Object.ReferenceEquals(b1,b2))
            {
                Console.WriteLine("Ref Equal \nVolume = {0} ", b1.Volume());
            }
            else
            {

                Console.WriteLine("Ref Not Equal \nVolume = {0} ", b1.Volume());
            }
        }

        public void ValEquivalenceCheck()
        {
            Box sb1 = new Box(4, 5, 6);
            Box sb2 = new Box(4,5,6);
            
            if (sb1.Equals(sb2))
            {
                Console.WriteLine("Val Equal");
            }
            else
            {
                Console.WriteLine("Val Not Equal");
            }
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            //p.RefEquivalenceCheck();
            //p.ValEquivalenceCheck();
            //p.CheckReferenceEqual();
            BoxUnbox ob = new BoxUnbox();
            //ob.BoxSomething();
            ob.UnBoxSomething();
            Console.ReadKey();

        }
    }
}
