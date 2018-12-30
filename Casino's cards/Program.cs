using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino_s_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var cards = new string[]
            {
                "2S", "2C", "2D", "2H", "3S", "3C", "3D", "3H", "4S", "4C", "4D", "4H", "5S", "5C", "5D", "5H", "6S", "6C", "6D", "6H", "7S", "7C", "7D", "7H", "8S", "8C", "8D", "8H", "9S", "9C", "9D", "9H", "TS", "TC", "TD", "TH", "JS", "JC", "JD", "JH", "QS", "QC", "QD", "QH", "KS", "KC", "KD", "KH", "AS", "AC", "AD", "AH", "2S", "2C", "2D", "2H", "3S", "3C", "3D", "3H", "4S", "4C", "4D", "4H", "5S", "5C", "5D", "5H", "6S", "6C", "6D", "6H", "7S", "7C", "7D", "7H", "8S", "8C", "8D", "8H", "9S", "9C", "9D", "9H", "TS", "TC", "TD", "TH", "JS", "JC", "JD", "JH", "QS", "QC", "QD", "QH", "KS", "KC", "KD", "KH", "AS", "AC", "AD", "AH", "2S", "2C", "2D", "2H", "3S", "3C", "3D", "3H", "4S", "4C", "4D", "4H", "5S", "5C", "5D", "5H", "6S", "6C", "6D", "6H", "7S", "7C", "7D", "7H", "8S", "8C", "8D", "8H", "9S", "9C", "9D", "9H", "TS", "TC", "TD", "TH", "JS", "JC", "JD", "JH", "QS", "QC", "QD", "QH", "KS", "KC", "KD", "KH", "AS", "AC", "AD"
            };

            var sortedCards = SortCards(cards);

            var decksCounter = sortedCards.Values.Min();

            Console.WriteLine($"Decks count : {decksCounter}");

            Console.ReadKey();
        }

        private static Dictionary<string, int> SortCards(string[] cards)
        {
            var CONSTANT_SOURCE = new CardConstants();
            var dicationary = new Dictionary<string, int>();

            var cardTypes = CardConstants.GetCardTypes();

            foreach(var cardType in cardTypes)
            {
                var cardsCounter = cards.Count(t => t == cardType);

                dicationary.Add(cardType, cardsCounter);
            }

            return dicationary;
        }
    }
}
