using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Inlamning_Kortspel
{
    public class HandOfCards
    {
      
        private string card;
        private Player player;
        private int cardValue;
        public List<string> hand = new List<string>();
      


        public HandOfCards(Player pl)
        {

            player = pl;
    
        }

        //Shows the card in the players hand
        public void ShowHand()
        {
            Console.WriteLine($"\nThese cards belongs to  {player.Name}: ");
            foreach (string card in hand)
            {
                Console.WriteLine(card);
            }


        }
         //Sum the cards in the players hands.
         public void SumCards()
        {
            
            cardValue = 0;
            foreach (var card in player.TheHand.hand)
            {
                

                if (card.Remove(0, 1) == "A") //prints "A" as nr1
                {
                    cardValue = cardValue + 1;
                }

               else if (card.Remove(0, 1) == "10") //prints "10" as 10
                {
                    cardValue = cardValue + 10;
                   
                }

                else if (card.Remove(0, 1) == "J") //Prints "J" as 11
                {
                    cardValue = cardValue + 11;
                }

                else if (card.Remove(0, 1) == "Q") //Prints "Q" as 12
                {
                    cardValue = cardValue + 12; 
                }
                else if (card.Remove(0, 1) == "K") //Prints "K" as 13
                {
                    cardValue = cardValue + 13;
                }
                else cardValue = cardValue + (int)char.GetNumericValue(card[1]);
            }

            
            Console.WriteLine($" -- {player.Name} scores: {cardValue} points! -- ");
 
         
        }

 
        public string Card { get => card; set => card = value; }
        public int CardValue { get => cardValue; set => cardValue = value; }
        public List<string> Hand { get => hand; set => hand = value; }
    
    }
}


