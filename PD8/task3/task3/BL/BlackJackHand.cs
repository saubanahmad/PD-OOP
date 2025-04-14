using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckGame;
using Task2.BL;

internal class BlackJackHand : Hand
{
   
    public int getBlackjackValue()
    {
        int total = 0;  // This will hold the total value of the hand.
        int aceCount = 0;  // Count of aces found in the hand.
        int cardCount = GetCardCount();  // Method inherited from Hand.

        // Process each card in the hand.
        for (int i = 0; i < cardCount; i++)
        {
            Card card = GetCard(i);  // Get the current card (inherited from Hand).
            int cardValue = card.getValue();

            if (cardValue == 1)
            {
                // Count aces separately. Initially count each Ace as 11.
                aceCount++;
                total += 11;
            }
            else if (cardValue >= 11 && cardValue <= 13)
            {
                // Face cards (Jack, Queen, King) are worth 10.
                total += 10;
            }
            else
            {
                // Numeric cards from 2 to 10 add their face value.
                total += cardValue;
            }
        }

        // Adjust for aces: if total exceeds 21, reduce the value of each ace from 11 to 1 by subtracting 10.
        while (total > 21 && aceCount > 0)
        {
            total -= 10;
            aceCount--;
        }

        return total;
    }  // end getBlackjackValue()
}  // end class BlackjackHand

