using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Inlamning_Kortspel
{
    public class Game
    {
        

        Player playerOne;
        Player playerTwo;
        CardDeck deckOfCards;
        private List<Player> players = new List<Player>();
        


        public Game()
        {
           
           deckOfCards = new CardDeck();
        
        }

        public void AddPlayerToTheGame()
        {
            
            Console.WriteLine("**** Let's play! ****\n ");
            Console.WriteLine("Please enter first players name: ");
            Players.Add(playerOne = new Player(Console.ReadLine()));
            Console.WriteLine("\nEnter second players name: ");
            Players.Add(playerTwo = new Player(Console.ReadLine()));
            Console.WriteLine($"\nWelcome {playerOne.Name} and {playerTwo.Name}! ");
     
        }
        //Deal a card to each player at index 0-1 in list of Players
        public void DealOneCard()
        {

            deckOfCards.DealCard(Players[0]);
            
            deckOfCards.DealCard(Players[1]);

           
        }
        // To show what's in/left in deck. Not used in the game atm.
        public void ShowCardsInDeck()
        {
            Console.WriteLine("This is whats's in the deck: ");

            deckOfCards.ShowDeck();
           
        }

        public void RulesGame()
        {
            Console.WriteLine("Welcome to The Highest Score Game!");
            Console.WriteLine(" \n-----RULES-----");
            Console.WriteLine("This is a game that requires two players.");
            Console.WriteLine("Players get 5 random cards each, every other card at a time.");
            Console.WriteLine("The winner is the player with the highest total score of five cards.\n");
            Console.WriteLine("The points are the same as the cards facing number.");
            Console.WriteLine("Royals and Ace are count for as follow: ");
            Console.WriteLine("A = 1p.");
            Console.WriteLine("Jack = 11p.");
            Console.WriteLine("Queen = 12p.");
            Console.WriteLine("King = 13p.");
            Console.WriteLine("Have fun!\n");

        }
        // The start up method for the game that runs in Main.
        //Using Thread Sleep so the dealing card process runs slower
        public void StartTheGame()
        {
             
            AddPlayerToTheGame();
            Console.WriteLine("\n**** Now you will receive your five cards ****\n");
               
            //Deal 5 cards to each player
            for (int i = 0; i < 5; i++)
            {
                DealOneCard();
                Thread.Sleep(1000);

                foreach (var player in players)
                {
                    player.ShowPlayerCards();
                    player.ShowPlayerSum();
       
                }
            }
       
        }
        //Who wins the game 
        public void WinningGame()
        {

            if (playerOne.TheHand.CardValue > playerTwo.TheHand.CardValue)
            {
                Console.WriteLine($"\nBIG congratulations {playerOne.Name}! You scored " +
                    $"{playerOne.TheHand.CardValue} points and wins the game!");

            }
            else if (playerOne.TheHand.CardValue < playerTwo.TheHand.CardValue)

            {
                Console.WriteLine($"\nBIG congratulations! {playerTwo.Name} scored" +
                    $" {playerTwo.TheHand.CardValue} points and wins the game!");

            }
            else
                Console.WriteLine("\nYou are both lucky today! It's a tie!");
        }

        public void PlayOneMoreTime()
            {
                while (true)
                {
                    Game PlayAgain = new Game();

                    Console.Write("\nDo you want to play the game again? [Y/N]?");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                    {

                        Console.WriteLine("Your answer is Yes. Wait a sec and a new game will run.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        PlayAgain.StartTheGame();
                        PlayAgain.WinningGame();
                        break;


                    }

                    else if (answer == "N")
                    {

                        Console.WriteLine($"Your answer is No. See you another time!");
                        break;
                    }

                    else Console.WriteLine("Try to answer correctly.");
                    Console.ReadKey();


                }
            }
       


        public List<Player> Players { get => players; set => players = value; }
        public Player PlayerOne { get => playerOne; set => playerOne = value; }
        public Player PlayerTwo { get => playerTwo; set => playerTwo = value; }
        public CardDeck DeckOfCards { get => deckOfCards; set => deckOfCards = value; }
        
    }
}
