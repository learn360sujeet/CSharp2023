using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_Encapsulation_simple
{
    // Encapsulation = hiding (Process of hiding unnecessary things from user)
    // Abstraction = Showing (Process of showing only necessary things to user)


    internal class Bank
    {

        // Abstraction = public
        public void showMeElectionReport()
        {

            Console.WriteLine(" ABC party won the election");

            CalC1();
            StateCal();
        }


        // encapsulation =private
        private void CalC1()
        {
            int c = 797 * 5 + 56 - 67 / 67 - 56;

            StateCal();

        }

        private void StateCal()
        {
            int m = 97 * 5 + 56 - 67 / 67 - 66;

            COuntryCal();

        }

        private void COuntryCal()
        {
            int v = 907 * 5 + 56 - 67 / 67 - 66;

        }



    }
}
