using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace Inlamning_Kortspel
{
    public class Program
    {


        static void Main(string[] args)

        {
            //Lisa Hultgren - august 2021

            //-----------The Highest Score - Card Game-------

            //-----RULES------

            //This is a game that requires two players.
            //Players get 5 random cards each, every other card at a time.
            //The winner of the game is the player with the highest total score
            //of the 5 cards.
            //The points are the same as the facing number of the card.
            //Royals and ace are count for as follow:
            // A = 1p.
            // Jack = 11p.
            // Queen == 12p.
            // King == 13p.

            //Have fun!


            //Create the game.
            Game Game = new Game();

            //Rules for the Game
            Game.RulesGame();

            //Start the game
            Game.StartTheGame();

            //Who wins the game
            Game.WinningGame();

            //Possible to play the game one more time with this loop.
            Game.PlayOneMoreTime();


            }


        }

  
}
