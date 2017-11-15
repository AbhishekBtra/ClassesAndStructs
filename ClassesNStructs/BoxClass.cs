using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesNStructs
{
    class BoxClass
    {
        int width;
        int height;
        int length;

        public BoxClass(int a,int b,int c)
        {
            width = a;
            height = b;
            length = c;

        }

        public int Volume()
        {
            return width * height * length;
        }
    }
}
