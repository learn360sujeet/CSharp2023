using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_property_PropertyShortForm
{
    internal class PropertyShortForm
    {

        // Short form
        // get - read  ,  set - write 
        public int AgeV1 { get; set; }


        // Write only proerty
        public int AgeV2 
        {
            // setter / write 
            set
            {
                age = value;
            } 
        }


        // Ready only property 
        public int AgeV3
        {
            // setter / write 
            get
            {
                return age;
            }
        }



        #region age property
        int age;
        public int Age
        {
            // getter to get value 
            get
            {
                return age;
            }

            // settter to set value
            set
            {
                if (value >= 18)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age must be greate or equal than 18");
                }
            }
        } 
        #endregion
    }
}
