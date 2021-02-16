using System;

namespace Print_until
{
    class Program
    {
        static void Main(string[] args)
        {
            Print_untilNum(4);
        }

        static void Print_untilNum(int value)
        {
            if (value < 0) 
            {
                Console.WriteLine("Given number too small.");
                return; 
            }
            for (int i = 0; i <= value ; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
