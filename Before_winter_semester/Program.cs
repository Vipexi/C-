using System;

namespace Before_winter_semester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string haystack = "There are Snakes on this plane";
            Console.WriteLine(Amethod("snakes", haystack));
            Console.WriteLine(Amethod("Snakes", haystack));
            Console.WriteLine(Amethod("snakes2", haystack));


        }

        static bool Amethod(string needle, string haystack)
        {
            int needleLen = needle.Length;

            for (int i = 0; i < haystack.Length - needleLen; i++) 
            {
                string tmp = haystack.Substring(i, needleLen);
                if (tmp.Equals(needle))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
