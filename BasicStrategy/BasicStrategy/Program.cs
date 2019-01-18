using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> deck1 = new CardDeck().Deck;


            //Deal Cards
            Card pCard1 = CardDeck.dealCard(deck1);
            Card pCard2 = CardDeck.dealCard(deck1);
            Card dCard1 = CardDeck.dealCard(deck1);

            //Calc Hard and Soft Values
            int sHandValue = CardHand.sValue(pCard1, pCard2);
            int hHandValue = CardHand.hValue(pCard1, pCard2);

            //If Player Card 2 is Ace, then swap Player Card 1 and 2 with eachother
            Card swapCard = new Card();

            if (pCard2.Face == "A")
            {
                swapCard.Face = pCard1.Face;
                pCard1.Face = pCard2.Face;
                pCard2.Face = swapCard.Face;
            }

            // update J,Q,K to rule value 10 for matrix look up.
            Card pCard1value = new Card();
            Card pCard2value = new Card();
            Card dCard1value = new Card();

            if (pCard1.Face == "J","Q","K")
            {
                pCard1value.Face = "10";
            }


            //Calc Hit, Stand, Double, Split based on Basic Strategy
            List<CardHand> rules1 = new Ruleset().BSMatrix1;
            List<CardHand> rules2 = new Ruleset().BSMatrix2;

            var bAction = from c in rules1
                                where c.pCard1 == pCard1.Face && c.pCard2 == pCard2.Face && c.dCard1 == dCard1.Face
                                select c;


            Console.WriteLine("Dealer Card: " + dCard1.Face);
            Console.Write(Environment.NewLine);
            Console.Write(Environment.NewLine);
            Console.WriteLine("Player Hand: " + pCard1.Face + "," + pCard2.Face);
            Console.WriteLine("Soft Value: " + sHandValue);
            Console.WriteLine("Hard Value: " + hHandValue);
            Console.Write(Environment.NewLine);

            foreach (var action in bAction)
                {
                   Console.WriteLine(action.bestAction);
                }


            Console.Write(Environment.NewLine);

            string input = Console.ReadLine();

            Console.Write(Environment.NewLine);
            Console.WriteLine(input);

            
            
            string input_end = Console.ReadLine();

            //var filteredCards = from c in deck1
            //                    where c.HardValue == 10 && c.Suit.StartsWith("H")
            //                    orderby c.Face
            //                    select c;

            //foreach (var card in filteredCards)
            //{
            //    Console.WriteLine(card.Suit + " " +card.Face + " " + card.HardValue);
            //}
            //Console.Read();

            //foreach (var card in cards)
            //{
            //    console.writeline(card.face);

            //}
            //console.readline();

        }
    }
}
