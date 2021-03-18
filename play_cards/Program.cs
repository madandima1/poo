using System;

namespace play_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck=new Deck();
            deck.PrintDeck();
            System.Console.WriteLine();
            Console.ReadKey();
            deck.shuffle();
            //deck.Draw(); are overload fara parametru un singur draw cu parametru un int x draw
        
        }
    }
}
