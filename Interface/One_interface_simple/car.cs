using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_interface_simple
{
    internal class car : Icar // implement 
    {
        public void wheel_1()
        {
            Console.Write("wheel_1 details and implementation");
          
        }

        public void wheel_2()
        {
            Console.Write("wheel_3 details and implementation");
        }

        public void wheel_3()
        {
            Console.Write("wheel_3 details and implementation");
        }

        public void wheel_4()
        {
            Console.Write("wheel_4 details and implementation");
        }
        public void wheel_backup()
        {
            Console.Write("wheel_4 details and implementation");
        }

    }
}
