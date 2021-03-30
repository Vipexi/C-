using System;
using System.Linq;


namespace ArrayExcercise
{
    class Program
    {

        
        public static void Main(string[] args)
        {
            int [] arrayWithInts = {3,5,7,9};

            for (int i = 0; i <= arrayWithInts.Length-1; i++)
            {
                for (int j = 0; j <= arrayWithInts.Length-1; j++)
                {
                    int [] result = {arrayWithInts[i]*arrayWithInts[j]};
                    
                    int [] LastResult = result.Distinct().ToArray();

                    Console.WriteLine(string.Join(" ", LastResult));

                    
                }
            }
            
        }
            
    }
}
