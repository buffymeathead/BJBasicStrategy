using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BasicStrategy
{
    class CardDeck
    {
        public List<Card> Deck = new List<Card>
            {
                new Card {Id = 1,Suit="Heart",Face="A", HardValue=1, SoftValue=11},
                new Card {Id = 2,Suit="Heart",Face="K", HardValue=10, SoftValue=10},
                new Card {Id = 3,Suit="Heart",Face="Q", HardValue=10, SoftValue=10},
                new Card {Id = 4,Suit="Heart",Face="J", HardValue=10, SoftValue=10},
                new Card {Id = 5,Suit="Heart",Face="10", HardValue=10, SoftValue=10},
                new Card {Id = 6,Suit="Heart",Face="9", HardValue=9, SoftValue=9},
                new Card {Id = 7,Suit="Heart",Face="8", HardValue=8, SoftValue=8},
                new Card {Id = 8,Suit="Heart",Face="7", HardValue=7, SoftValue=7},
                new Card {Id = 9,Suit="Heart",Face="6", HardValue=6, SoftValue=6},
                new Card {Id = 10,Suit="Heart",Face="5", HardValue=5, SoftValue=5},
                new Card {Id = 11,Suit="Heart",Face="4", HardValue=4, SoftValue=4},
                new Card {Id = 12,Suit="Heart",Face="3", HardValue=3, SoftValue=3},
                new Card {Id = 13,Suit="Heart",Face="2", HardValue=2, SoftValue=2},

                new Card {Id = 14,Suit="Diamond",Face="A", HardValue=1, SoftValue=11},
                new Card {Id = 15,Suit="Diamond",Face="K", HardValue=10, SoftValue=10},
                new Card {Id = 16,Suit="Diamond",Face="Q", HardValue=10, SoftValue=10},
                new Card {Id = 17,Suit="Diamond",Face="J", HardValue=10, SoftValue=10},
                new Card {Id = 18,Suit="Diamond",Face="10", HardValue=10, SoftValue=10},
                new Card {Id = 19,Suit="Diamond",Face="9", HardValue=9, SoftValue=9},
                new Card {Id = 20,Suit="Diamond",Face="8", HardValue=8, SoftValue=8},
                new Card {Id = 21,Suit="Diamond",Face="7", HardValue=7, SoftValue=7},
                new Card {Id = 22,Suit="Diamond",Face="6", HardValue=6, SoftValue=6},
                new Card {Id = 23,Suit="Diamond",Face="5", HardValue=5, SoftValue=5},
                new Card {Id = 24,Suit="Diamond",Face="4", HardValue=4, SoftValue=4},
                new Card {Id = 25,Suit="Diamond",Face="3", HardValue=3, SoftValue=3},
                new Card {Id = 26,Suit="Diamond",Face="2", HardValue=2, SoftValue=2},

                new Card {Id = 27,Suit="Spade",Face="A", HardValue=1, SoftValue=11},
                new Card {Id = 28,Suit="Spade",Face="K", HardValue=10, SoftValue=10},
                new Card {Id = 29,Suit="Spade",Face="Q", HardValue=10, SoftValue=10},
                new Card {Id = 30,Suit="Spade",Face="J", HardValue=10, SoftValue=10},
                new Card {Id = 31,Suit="Spade",Face="10", HardValue=10, SoftValue=10},
                new Card {Id = 32,Suit="Spade",Face="9", HardValue=9, SoftValue=9},
                new Card {Id = 33,Suit="Spade",Face="8", HardValue=8, SoftValue=8},
                new Card {Id = 34,Suit="Spade",Face="7", HardValue=7, SoftValue=7},
                new Card {Id = 35,Suit="Spade",Face="6", HardValue=6, SoftValue=6},
                new Card {Id = 36,Suit="Spade",Face="5", HardValue=5, SoftValue=5},
                new Card {Id = 37,Suit="Spade",Face="4", HardValue=4, SoftValue=4},
                new Card {Id = 38,Suit="Spade",Face="3", HardValue=3, SoftValue=3},
                new Card {Id = 39,Suit="Spade",Face="2", HardValue=2, SoftValue=2},

                new Card {Id = 40,Suit="Club",Face="A", HardValue=1, SoftValue=11},
                new Card {Id = 41,Suit="Club",Face="K", HardValue=10, SoftValue=10},
                new Card {Id = 42,Suit="Club",Face="Q", HardValue=10, SoftValue=10},
                new Card {Id = 43,Suit="Club",Face="J", HardValue=10, SoftValue=10},
                new Card {Id = 44,Suit="Club",Face="10", HardValue=10, SoftValue=10},
                new Card {Id = 45,Suit="Club",Face="9", HardValue=9, SoftValue=9},
                new Card {Id = 46,Suit="Club",Face="8", HardValue=8, SoftValue=8},
                new Card {Id = 47,Suit="Club",Face="7", HardValue=7, SoftValue=7},
                new Card {Id = 48,Suit="Club",Face="6", HardValue=6, SoftValue=6},
                new Card {Id = 49,Suit="Club",Face="5", HardValue=5, SoftValue=5},
                new Card {Id = 50,Suit="Club",Face="4", HardValue=4, SoftValue=4},
                new Card {Id = 51,Suit="Club",Face="3", HardValue=3, SoftValue=3},
                new Card {Id = 52,Suit="Club",Face="2", HardValue=2, SoftValue=2},
            };

        //ref to random class

        public static Random rnd = new Random();

        public static  Card dealCard(List<Card> deck)
        {
            var i = rnd.Next(53);

            return (from c in deck
                    where c.Id == i
                    select c).SingleOrDefault();

        }



    }
}

