using System;

namespace basic_01
{
    class Program
    {
        //def Main(args):
        static void Main(string[] args)
        {   //print("Hello World!")
            Console.WriteLine("Hello World!");
            
            // variable
            string name ="Ville";

            // printing the variable
            Console.WriteLine(name);

            int age = 28;
            double someNumber;
            someNumber = 3.23123;

            float floatVar = 3.23123f;
            bool asd = true;

            Console.WriteLine(asd);

            Console.WriteLine($"asdad {asd} {15 + 15} {someNumber} {floatVar} {age}");

            SayHello();

            int multiplied = Multiply(13);
            Console.WriteLine(multiplied);
            double multiplied2=Multiply(12);
            Console.WriteLine(multiplied2);


        }

        static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        static int Multiply(int n) 
        {
            return n * 2;
        

        }
        static double Multiply2(double n)
        {
            return n+n;
        }

        //static void (string[] args)
    }
}
