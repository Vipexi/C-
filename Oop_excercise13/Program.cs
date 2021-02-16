using System;

namespace Oop_excercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int random_number = 41;
            if (random_number == 42)
            {
               Console.WriteLine(random_number); 
            }
            else
            {
                Console.WriteLine("funny value");
            }

            Console.WriteLine("Give me your name:  ");
            string Name = Console.ReadLine();
            Console.WriteLine($"Hi {Name},nice to meet you!");
            Console.WriteLine($"Your name has {Name.Length} characters...");

            

            Console.WriteLine("Give me a number: ");
            string input = Console.ReadLine();

            Console.WriteLine(input);
            int inputInt = int.Parse(input);
            Console.WriteLine(inputInt);

            if (inputInt % 2 == 0) {
                Console.WriteLine("The number is even");
            }        
            else {
                Console.WriteLine("The numbers is odd");
            }

            Console.WriteLine("Give me a number: ");
            string something = Console.ReadLine();

            Console.WriteLine(something);
            int answer = int.Parse(something);
            Console.WriteLine(answer);

            int x = 10;
            int y = 21;

            if (answer < x) {
                Console.WriteLine("The number is smaller than 10.");
            }
            else if ( x <= answer && answer < y) {
                Console.WriteLine("The number is less than 20.");
            }
            else {
                Console.WriteLine("The number is greater than 20.");
            }

            Console.WriteLine("Give a number:");
            string user_answer = Console.ReadLine();

            Console.WriteLine(user_answer);
            int number_answer = int.Parse(user_answer);

            int ten = 10;
            double twopointfive = 2.5;

            switch(number_answer) 
            {
                case 1:
                    number_answer = 10;
                    int result1 = number_answer * ten;
                    Console.WriteLine(result1);
                    break;

                case 2:
                    number_answer = 20;
                    double result2 = number_answer * twopointfive;
                    Console.WriteLine(result2);
                    break;

                case 3:
                    number_answer = 30;
                    Console.WriteLine("That is a great number!");
                    break;

                case 4:
                    number_answer= 40;
                    Console.WriteLine("That is a great number!");
                    break;

                default:
                    Console.WriteLine("Goodbye!");
                    break;   
            }

            
        }    


        

    }
}
