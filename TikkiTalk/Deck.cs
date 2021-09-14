using System;
using System.Collections.Generic;

namespace TikkiTalk
{
    public class Deck
    {
        public List<Card> Cards { get; private set; }

        public int CardCount { get; private set; }

        public Deck()
        {
            MakeDeck();
            CardCount = Cards.Count;
        }

        public void MakeDeck()
        {
            string[] suits = { "spade", "diamond", "heart", "club" };

            List<Card> cards = new List<Card>();

            foreach (string suit in suits)
            {
                for (int rank = 1; rank < 14; rank++)
                {
                    Card c = new Card(rank, suit);
                    cards.Add(c);
                }
                
            }

            Cards = cards;
            
        }

        public static void shuffle(int rounds)
        {
            
            Random rand = new Random();
            
            for (int i = 0; i < rounds; i++)
            {
                
                int r = i + rand.Next(52 - i);
              
            
                int temp = card[r];
                card[r] = card[i];
                card[i] = temp;
                
            }
        }
    }
}
