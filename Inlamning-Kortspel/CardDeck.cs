using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;




namespace Inlamning_Kortspel
{
    public class CardDeck
    {
        
        private string newCard;
        Random rnd = new Random();
        private List<string> deck = new List<string>();

       

        public CardDeck() 
        {
          
            string colours = "♥♠♣♦";
            string ranks = "A23456789XJQK";
            

            foreach (var colour in colours)
            {
                
                foreach (var rank in ranks)
                {
                    
                   Deck.Add(colour + (rank == 'X' ? "10" : rank + ""));
                }
            }
                    Deck = Deck.OrderBy(item => rnd.Next()).ToList(); 

        }

         public void ShowDeck() 
        {
            foreach (string card in Deck)  
            {
                Console.WriteLine(card);

            
            }
                Console.WriteLine("This Deck contains " + Deck.Count + " cards."); 
        }


       public void DealCard(Player player) 

        {
        
            newCard = Deck[0];
            Deck.RemoveAt(0);

            player.TheHand.Hand.Add(newCard);

        }


       
        public string NewCard { get => newCard; set => newCard = value; }
        public List<string> Deck { get => deck; set => deck = value; }

    }
}
