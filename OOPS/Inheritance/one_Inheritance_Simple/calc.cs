using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_Inheritance_Simple
{
    // calc - Child/derived 
    // Calculator - parent/base
    public class calc : Calculator // inheritance 
    {

        public int multi(int x, int y)
        {
            return x * y;
        }

        public int divide(int x, int y)
        {
            return x/y;
        }
    }


}
