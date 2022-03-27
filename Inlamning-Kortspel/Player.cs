using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;



namespace Inlamning_Kortspel
{
    public class Player 
    {
        
        private string name;
        private HandOfCards theHand;

      
        public Player(string name)
        {
            Name = name;
            TheHand = new HandOfCards(this);
     
        }
  
        public void ShowPlayerCards() 

        {
            TheHand.ShowHand();

        }

        public void ShowPlayerSum( )
        {
      
            TheHand.SumCards();
     
        }


        public string Name { get => name; set => name = value; }
        public HandOfCards TheHand { get => theHand; set => theHand = value; }
     
    }
}
