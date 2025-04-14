using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    internal class Deck
    {
        private int count;
        private Card[] deck = new Card[52];
        public Deck()
        {
            count = 0;
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    deck[count] = new Card(value, suit);
                    count++;
                }
            }
            count = 52;
        }
        public void Shuffle()
        {

            System.Random rand = new Random();
            Card temp;
            for (int i = 0; i < 52; i++)
            {
                int num = rand.Next(0, 52);
                temp = deck[num];
                deck[num] = deck[i];
                deck[i] = temp;
            }
        }
        public int CardsLeft()
        {
            return count;
        }
        public Card DealCard()
        {
            if (count > 0)
            {
                count--;
                return deck[count];
            }
            else return null;
        }
    }
}
