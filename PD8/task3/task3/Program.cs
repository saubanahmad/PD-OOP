using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace task3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();

            BlackJackHand playerHand = new BlackJackHand();
            BlackJackHand dealerHand = new BlackJackHand();

            // Initial deal
            playerHand.AddCard(deck.DealCard());
            playerHand.AddCard(deck.DealCard());
            dealerHand.AddCard(deck.DealCard());
            dealerHand.AddCard(deck.DealCard());

            Console.WriteLine("Welcome to Blackjack!\n");

            // Show initial hands
            Console.WriteLine("Dealer's Hand:");
            Console.WriteLine(dealerHand.GetCard(0));
            Console.WriteLine("  [Hidden Card]\n");

            Console.WriteLine("Your Hand:");
            for (int i = 0; i < playerHand.GetCardCount(); i++)
                Console.WriteLine(playerHand.GetCard(i));
            Console.WriteLine($"Total: {playerHand.getBlackjackValue()}\n");

            bool playerBust = false;
            bool dealerBust = false;
            bool gameOver = false;

            // Check for player blackjack
            if (playerHand.getBlackjackValue() == 21)
            {
                Console.WriteLine("Blackjack! Checking dealer's hand...\n");
                Console.WriteLine("Dealer's Hand:");
                for (int i = 0; i < dealerHand.GetCardCount(); i++)
                    Console.WriteLine($"  {dealerHand.GetCard(i)}");
                int dealerValue = dealerHand.getBlackjackValue();
                Console.WriteLine($"Dealer's Total: {dealerValue}\n");

                if (dealerValue == 21)
                    Console.WriteLine("Both have Blackjack! Push.");
                else
                    Console.WriteLine("You win with a Blackjack!");
                gameOver = true;
            }

            // Player's turn
            if (!gameOver)
            {
                while (true)
                {
                    Console.Write("(H)it or (S)tand? ");
                    string input = Console.ReadLine().Trim().ToUpper();

                    if (input == "H")
                    {
                        Card newCard = deck.DealCard();
                        if (newCard == null)
                        {
                            Console.WriteLine("Deck is empty!");
                            break;
                        }
                        playerHand.AddCard(newCard);
                        Console.WriteLine($"\nYou drew: {newCard}");
                        Console.WriteLine($"New Total: {playerHand.getBlackjackValue()}\n");

                        if (playerHand.getBlackjackValue() > 21)
                        {
                            Console.WriteLine("Bust! You lose.");
                            playerBust = true;
                            gameOver = true;
                            break;
                        }
                    }
                    else if (input == "S")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter H or S.");
                    }
                }
            }

            // Dealer's turn
            if (!gameOver && !playerBust)
            {
                Console.WriteLine("\nDealer's Turn:");
                Console.WriteLine("Dealer's Hand:");
                for (int i = 0; i < dealerHand.GetCardCount(); i++)
                    Console.WriteLine($"  {dealerHand.GetCard(i)}");
                int dealerValue = dealerHand.getBlackjackValue();
                Console.WriteLine($"Dealer's Total: {dealerValue}\n");

                while (dealerValue < 17)
                {
                    Card newCard = deck.DealCard();
                    if (newCard == null)
                    {
                        Console.WriteLine("Deck is empty!");
                        break;
                    }
                    dealerHand.AddCard(newCard);
                    dealerValue = dealerHand.getBlackjackValue();
                    Console.WriteLine($"Dealer drew: {newCard}");
                    Console.WriteLine($"Dealer's Total: {dealerValue}\n");

                    if (dealerValue > 21)
                    {
                        Console.WriteLine("Dealer busts!");
                        dealerBust = true;
                        break;
                    }
                }
            }

            // Determine winner
            if (playerBust)
                Console.WriteLine("You busted. Dealer wins.");
            else if (dealerBust)
                Console.WriteLine("Dealer busts. You win!");
            else if (!gameOver)
            {
                int playerTotal = playerHand.getBlackjackValue();
                int dealerTotal = dealerHand.getBlackjackValue();

                Console.WriteLine("\nFinal Results:");
                Console.WriteLine($"Your Total: {playerTotal}");
                Console.WriteLine($"Dealer's Total: {dealerTotal}\n");

                if (playerTotal > dealerTotal)
                    Console.WriteLine("You win!");
                else if (dealerTotal > playerTotal)
                    Console.WriteLine("Dealer wins.");
                else
                    Console.WriteLine("Push. It's a tie.");
            }

            Console.WriteLine("\nGame Over. Thanks for playing!");
        }
    }
}

