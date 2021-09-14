using System;
using System.Collections.Generic;
namespace TikkiTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand hand = new Hand();

            Console.WriteLine("Welcome to my came of Tikki! How many rounds would you like to play? 1 is the least amount and 26 is the maximum: ");
            int rounds = Console.Read();
           
           while(rounds < 27)
           {
               deck.shuffle(rounds);
           }

            
            


            


        }
    }
}
