using System;

namespace SwitchCase
{
    class Program
    {
        static void Main()
        {

            int num = 10;

            switch(num) {

                case 1:
                    Console.WriteLine(1);
                    break;

                case 2:
                    Console.WriteLine(2);
                    break;

                case 3:
                    Console.WriteLine("3 or 4");
                    break;

                default:
                    Console.WriteLine("something");
                    break;

            }
            /*int caseSwitch= 1;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;

                case 2:
                    Console.WriteLine("Case 2");
                    break;
                
                default:
                    Console.WriteLine("Neither!");
                    break;
                
            }*/
        }
    }
}
