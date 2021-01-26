using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 0;
            if (num == 0) {
                Console.WriteLine("true");
            }

            //elif
            else if (num ==2) {
                Console.WriteLine("2");
            }

            else {
                Console.WriteLine("false");
            }

            if (num != 4) {
                Console.WriteLine("not four");
            }

            /*bool a = false;
            bool b = true;

            // and &&
            if (a == true && b == true) {
                Console.WriteLine("Both are True!");

            }
            // or ||
            if (a == true || b == true) {
                Console.WriteLine("The other one is true!");
            }*/


        }
    }
}
