using System.Collections.Generic;
using System;
using System.Linq;

namespace play_cards
{
    public class Deck
    {
        public static List<Card> Cards = new List<Card>();
        public Deck()
        {
            for (int i = 0; i < 52; i++)
            {
                Card.Suits suite = ( Card.Suits ) (i / 13);
                int val = i%13 + 2;
                Cards.Add(new Card(val, suite));
            } 
        }
        private List<Card> ShuffledDeck;
        private Random rnd = new Random();
        public void shuffle()
        {
             rnd = new Random(DateTime.Now.Millisecond);
    
            ShuffledDeck = new List<Card>(52);
            
            int card;

            // secventa de la 0-52
            List<int> DeckSequence = Enumerable.Range(0, 52).ToList();

            for (int i = 0; i < 52; i++)
            {
                card = DeckSequence[rnd.Next(0, DeckSequence.Count)];
                DeckSequence.Remove(card);
                
                ShuffledDeck.Add(Cards[card]);
            }
            _PrintDeck();
        }
        public void PrintDeck()
        {
             
            foreach(Card card in Cards)
            {
                Console.WriteLine(card.Name);
            }
        }
        private void _PrintDeck()
        {
             
            foreach(Card card in ShuffledDeck)
            {
                Console.WriteLine(card.Name);
            }
        }
        public void Draw ()
        {
            int temp =rnd.Next(0,52);
            System.Console.WriteLine(Cards[temp]);
            Cards.RemoveAt(temp);
        }
        public void Draw(int number_of_draws)
        {
            int temp;
            for(int i=0;i<number_of_draws;i++)
            {
                temp = rnd.Next(0,52);
                System.Console.WriteLine(Cards[temp]);
                Cards.RemoveAt(temp);
            }
        }
    
    }
}