using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesNStructs
{
    class BaseClass
    {
        int x, y, z;

        public BaseClass()
        {
            x = 10;
            y = 10;
            z = 10;
        }

        public virtual int CalcVolume(int d)
        {
            int vol;
            return vol = x*y*z;
        }

        public int CalArea()
        {
            return x + y * z;
        }



        public int CalArea2()
        {
            return x + y * z;
        }

        public  int CalArea3()
        {
            return x + y * z;
        }


    }
}
