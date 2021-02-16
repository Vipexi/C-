using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            // i++ == i = i + 1
            // for (initialize the variable; condition; growing)
            // for i in range(0,5)
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(i);
            }
            
            int rounds = 0;
            while (rounds < 4) {
                Console.WriteLine(rounds);
                rounds++; 
            }

            rounds = 0;
            do {
                Console.WriteLine("do-while", rounds.ToString());
                rounds++;
            } while (rounds < 2);
        }
    }
}
