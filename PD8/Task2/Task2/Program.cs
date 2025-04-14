using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.WriteLine("Welcome to the card game.");
                Console.WriteLine("1. Play Game");
                Console.WriteLine("2. Exit");
                option = int.Parse(Console.ReadLine());
                Console.Clear();
                if (option == 1)
                {
                    bool gameRunning = true;
                    int score = 0;
                    Deck deck = new Deck();
                    deck.Shuffle();
                    Card card1 = deck.DealCard();
                    while (gameRunning)
                    {
                        int remain_check = deck.CardsLeft();
                        Card card2 = deck.DealCard();
                        Console.WriteLine("*******************************");
                        Console.WriteLine(card1.toString());
                        Console.WriteLine("");
                        Console.WriteLine("*** Remaining cards *** : " + remain_check);
                        Console.WriteLine("Enter 1 if the next card is higher.");
                        Console.WriteLine("Enter 2 if the next card is lower.");

                        int card_check = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (card_check == 1)
                        {
                            if (card2.getValue() >= card1.getValue())
                            {
                                score++;
                                card1 = card2;
                            }
                            else
                            {
                                gameRunning = false;
                                Console.WriteLine("SORRY YOU LOSE! PRESS ANY KEY TO CONTINUE.");
                                string card = card2.toString();
                                Console.WriteLine("The Card was " + card);
                                Console.WriteLine("You Score is : " + score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }

                        if (card_check == 2)
                        {
                            if (card2.getValue() < card1.getValue())
                            {
                                score++;
                                card1 = card2;
                            }
                            else
                            {
                                gameRunning = false;
                                Console.WriteLine("SORRY YOU LOSE! PRESS ANY KEY TO CONTINUE.");
                                Console.WriteLine("The Card was " + card2.toString());
                                Console.WriteLine("Your Score is : " + score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }

                        if (deck.CardsLeft() == 0 && card2 == null)
                        {
                            gameRunning = false;
                            Console.WriteLine("Congrats you have scored maximum.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    }
                }

            } while (option != 2);
        }
    }
}


