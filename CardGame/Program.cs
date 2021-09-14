using System;
using System.Collections.Generic;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Deck deck = new Deck();
            Hand hand = new Hand();
            Console.WriteLine("card count " + deck.CardCount);

            //Console.WriteLine(deck.Cards[0].Print());

            List<Card> drawn = new List<Card>();
            
            

            Console.WriteLine("-------------");
            Console.WriteLine("Pick where to divide the deck to begin the shuffle.");
            int whereToShuffle = Console.Read();
            drawn = deck.DrawTopN(whereToShuffle);
            
            deck.Shuffle();

            Console.WriteLine("How many rounds do you want to play?");
            int rounds = Console.Read();
            int sizeOfHand = rounds / 2;
            drawn = deck.DrawRandomN(sizeOfHand);

            Console.WriteLine("card count " + deck.CardCount);
            //hand.playerHand.Add(drawn);


            //Console.WriteLine(deck.Cards[0].Print());
            
            //Console.WriteLine(deck.Cards[0].Print());


        }
    }
}