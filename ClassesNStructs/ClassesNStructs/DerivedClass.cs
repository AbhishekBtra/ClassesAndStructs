using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesNStructs
{
    class DerivedClass : BaseClass
    {

        public override int CalcVolume()
        {

           
            //Console.WriteLine("Base classs volume = {0}", base.CalcVolume());
            return 1 * 2 * 3;

        }

        public int CalArea()
        {
            return 1+2*3;
        }

        public new int CalArea2()
        {
            return 1 + 2 * 3;
        }

    }
}
