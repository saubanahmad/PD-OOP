using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace DeckGame
{
    internal class Hand
    {
        private List<Card> cards;

        public Hand()
        {
            cards = new List<Card>();
        }

        public void Clear()
        {
            cards.Clear();
        }

        public void AddCard(Card c)
        {
            if (c != null)
                cards.Add(c);
        }

        public void RemoveCard(Card c)
        {
            cards.Remove(c);
        }

        public void RemoveCard(int position)
        {
            if (position >= 0 && position < cards.Count)
                cards.RemoveAt(position);
        }

        public int GetCardCount()
        {
            return cards.Count;
        }

        public Card GetCard(int position)
        {
            if (position < 0 || position >= cards.Count)
                return null;
            return cards[position];
        }

        public void SortBySuit()
        {
            cards.Sort((a, b) =>
            {
                int suitCompare = a.getSuit().CompareTo(b.getSuit());
                return suitCompare != 0 ? suitCompare : a.getValue().CompareTo(b.getValue());
            });
        }

        public void SortByValue()
        {
            cards.Sort((a, b) =>
            {
                int valueCompare = a.getValue().CompareTo(b.getValue());
                return valueCompare != 0 ? valueCompare : a.getSuit().CompareTo(b.getSuit());
            });
        }
    }
}

