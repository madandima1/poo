using System;
using System.Collections.Generic;
namespace play_cards
{
    public class Card
    {
        private int rank;
        private int suit;
        private static String [] suits =new string[4]{"Clubs","Diamonds","Hearts","Spades"};
        private static String [] ranks = new string []{null, "Ace", "2" ,"3","4", "5","6","7","8"
            ,"9","10", "Jack","Queen","King"};
        /*
        Ace>>>>>>1          Clubs-----0
        Queen>>>>12         Diamonds--1
        King>>>>13          Hearts----2
        Jack>>>11           Spades----3*/
        public Card (int rank, int suit)
        {   
            this.rank=rank;
            this.suit=suit;
        }
        public int getRank()
        {
            return this.rank;
        }

        public int getSuit() 
        {
            return this.suit;
        }
        public void print()
        {
            System.Console.WriteLine(ranks[rank] + " of "+suits[suit]);
        }
    }
}