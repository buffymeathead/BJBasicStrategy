using System;
using System.Collections.Generic;
using System.Text;

namespace BasicStrategy
{
    class Ruleset
    {

        public List<CardHand> BSMatrix1 = new List<CardHand>
        {
            
                // 2,2 Actions
                new CardHand {pCard1 = "2",pCard2 = "2",SoftValueTotal = 4, HardValueTotal = 4, dCard1 = "2", bestAction = "SP"},
                new CardHand {pCard1 = "2",pCard2 = "2",SoftValueTotal = 4, HardValueTotal = 4, dCard1 = "3", bestAction = "SP"},
                new CardHand {pCard1 = "2",pCard2 = "2",SoftValueTotal = 4, HardValueTotal = 4, dCard1 = "4", bestAction = "SP"},
                new CardHand {pCard1 = "2",pCard2 = "2",SoftValueTotal = 4, HardValueTotal = 4, dCard1 = "5", bestAction = "SP"},
                new CardHand {pCard1 = "2",pCard2 = "2",SoftValueTotal = 4, HardValueTotal = 4, dCard1 = "6", bestAction = "SP"},
                new CardHand {pCard1 = "2",pCard2 = "2",SoftValueTotal = 4, HardValueTotal = 4, dCard1 = "7", bestAction = "SP"},
                new CardHand {pCard1 = "2",pCard2 = "2",SoftValueTotal = 4, HardValueTotal = 4, dCard1 = "8", bestAction = "H"},
                new CardHand {pCard1 = "2",pCard2 = "2",SoftValueTotal = 4, HardValueTotal = 4, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "2",pCard2 = "2",SoftValueTotal = 4, HardValueTotal = 4, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "2",pCard2 = "2",SoftValueTotal = 4, HardValueTotal = 4, dCard1 = "A", bestAction = "H"},

                // 3,3 Actions
                new CardHand {pCard1 = "3",pCard2 = "3",SoftValueTotal = 6, HardValueTotal = 6, dCard1 = "2", bestAction = "SP"},
                new CardHand {pCard1 = "3",pCard2 = "3",SoftValueTotal = 6, HardValueTotal = 6, dCard1 = "3", bestAction = "SP"},
                new CardHand {pCard1 = "3",pCard2 = "3",SoftValueTotal = 6, HardValueTotal = 6, dCard1 = "4", bestAction = "SP"},
                new CardHand {pCard1 = "3",pCard2 = "3",SoftValueTotal = 6, HardValueTotal = 6, dCard1 = "5", bestAction = "SP"},
                new CardHand {pCard1 = "3",pCard2 = "3",SoftValueTotal = 6, HardValueTotal = 6, dCard1 = "6", bestAction = "SP"},
                new CardHand {pCard1 = "3",pCard2 = "3",SoftValueTotal = 6, HardValueTotal = 6, dCard1 = "7", bestAction = "SP"},
                new CardHand {pCard1 = "3",pCard2 = "3",SoftValueTotal = 6, HardValueTotal = 6, dCard1 = "8", bestAction = "H"},
                new CardHand {pCard1 = "3",pCard2 = "3",SoftValueTotal = 6, HardValueTotal = 6, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "3",pCard2 = "3",SoftValueTotal = 6, HardValueTotal = 6, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "3",pCard2 = "3",SoftValueTotal = 6, HardValueTotal = 6, dCard1 = "A", bestAction = "H"},

                // 4,4 Actions
                new CardHand {pCard1 = "4",pCard2 = "4",SoftValueTotal = 8, HardValueTotal = 8, dCard1 = "2", bestAction = "H"},
                new CardHand {pCard1 = "4",pCard2 = "4",SoftValueTotal = 8, HardValueTotal = 8, dCard1 = "3", bestAction = "H"},
                new CardHand {pCard1 = "4",pCard2 = "4",SoftValueTotal = 8, HardValueTotal = 8, dCard1 = "4", bestAction = "H"},
                new CardHand {pCard1 = "4",pCard2 = "4",SoftValueTotal = 8, HardValueTotal = 8, dCard1 = "5", bestAction = "SP"},
                new CardHand {pCard1 = "4",pCard2 = "4",SoftValueTotal = 8, HardValueTotal = 8, dCard1 = "6", bestAction = "SP"},
                new CardHand {pCard1 = "4",pCard2 = "4",SoftValueTotal = 8, HardValueTotal = 8, dCard1 = "7", bestAction = "H"},
                new CardHand {pCard1 = "4",pCard2 = "4",SoftValueTotal = 8, HardValueTotal = 8, dCard1 = "8", bestAction = "H"},
                new CardHand {pCard1 = "4",pCard2 = "4",SoftValueTotal = 8, HardValueTotal = 8, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "4",pCard2 = "4",SoftValueTotal = 8, HardValueTotal = 8, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "4",pCard2 = "4",SoftValueTotal = 8, HardValueTotal = 8, dCard1 = "A", bestAction = "H"},

                // 5,5 Actions
                new CardHand {pCard1 = "5",pCard2 = "5",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "2", bestAction = "D"},
                new CardHand {pCard1 = "5",pCard2 = "5",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "3", bestAction = "D"},
                new CardHand {pCard1 = "5",pCard2 = "5",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "4", bestAction = "D"},
                new CardHand {pCard1 = "5",pCard2 = "5",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "5", bestAction = "D"},
                new CardHand {pCard1 = "5",pCard2 = "5",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "6", bestAction = "D"},
                new CardHand {pCard1 = "5",pCard2 = "5",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "7", bestAction = "D"},
                new CardHand {pCard1 = "5",pCard2 = "5",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "8", bestAction = "D"},
                new CardHand {pCard1 = "5",pCard2 = "5",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "9", bestAction = "D"},
                new CardHand {pCard1 = "5",pCard2 = "5",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "5",pCard2 = "5",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "A", bestAction = "H"},

                // 6,6 Actions
                new CardHand {pCard1 = "6",pCard2 = "6",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "2", bestAction = "SP"},
                new CardHand {pCard1 = "6",pCard2 = "6",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "3", bestAction = "SP"},
                new CardHand {pCard1 = "6",pCard2 = "6",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "4", bestAction = "SP"},
                new CardHand {pCard1 = "6",pCard2 = "6",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "5", bestAction = "SP"},
                new CardHand {pCard1 = "6",pCard2 = "6",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "6", bestAction = "SP"},
                new CardHand {pCard1 = "6",pCard2 = "6",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "7", bestAction = "H"},
                new CardHand {pCard1 = "6",pCard2 = "6",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "8", bestAction = "H"},
                new CardHand {pCard1 = "6",pCard2 = "6",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "6",pCard2 = "6",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "6",pCard2 = "6",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "A", bestAction = "H"},

                // 7,7 Actions
                new CardHand {pCard1 = "7",pCard2 = "7",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "2", bestAction = "SP"},
                new CardHand {pCard1 = "7",pCard2 = "7",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "3", bestAction = "SP"},
                new CardHand {pCard1 = "7",pCard2 = "7",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "4", bestAction = "SP"},
                new CardHand {pCard1 = "7",pCard2 = "7",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "5", bestAction = "SP"},
                new CardHand {pCard1 = "7",pCard2 = "7",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "6", bestAction = "SP"},
                new CardHand {pCard1 = "7",pCard2 = "7",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "7", bestAction = "SP"},
                new CardHand {pCard1 = "7",pCard2 = "7",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "8", bestAction = "H"},
                new CardHand {pCard1 = "7",pCard2 = "7",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "7",pCard2 = "7",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "7",pCard2 = "7",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "A", bestAction = "H"},

                // 8,8 Actions
                new CardHand {pCard1 = "8",pCard2 = "8",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "2", bestAction = "SP"},
                new CardHand {pCard1 = "8",pCard2 = "8",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "3", bestAction = "SP"},
                new CardHand {pCard1 = "8",pCard2 = "8",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "4", bestAction = "SP"},
                new CardHand {pCard1 = "8",pCard2 = "8",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "5", bestAction = "SP"},
                new CardHand {pCard1 = "8",pCard2 = "8",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "6", bestAction = "SP"},
                new CardHand {pCard1 = "8",pCard2 = "8",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "7", bestAction = "SP"},
                new CardHand {pCard1 = "8",pCard2 = "8",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "8", bestAction = "SP"},
                new CardHand {pCard1 = "8",pCard2 = "8",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "9", bestAction = "SP"},
                new CardHand {pCard1 = "8",pCard2 = "8",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "10", bestAction = "SP"},
                new CardHand {pCard1 = "8",pCard2 = "8",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "A", bestAction = "SP"},

                // 9,9 Actions
                new CardHand {pCard1 = "9",pCard2 = "9",SoftValueTotal = 18, HardValueTotal = 18, dCard1 = "2", bestAction = "SP"},
                new CardHand {pCard1 = "9",pCard2 = "9",SoftValueTotal = 18, HardValueTotal = 18, dCard1 = "3", bestAction = "SP"},
                new CardHand {pCard1 = "9",pCard2 = "9",SoftValueTotal = 18, HardValueTotal = 18, dCard1 = "4", bestAction = "SP"},
                new CardHand {pCard1 = "9",pCard2 = "9",SoftValueTotal = 18, HardValueTotal = 18, dCard1 = "5", bestAction = "SP"},
                new CardHand {pCard1 = "9",pCard2 = "9",SoftValueTotal = 18, HardValueTotal = 18, dCard1 = "6", bestAction = "SP"},
                new CardHand {pCard1 = "9",pCard2 = "9",SoftValueTotal = 18, HardValueTotal = 18, dCard1 = "7", bestAction = "S"},
                new CardHand {pCard1 = "9",pCard2 = "9",SoftValueTotal = 18, HardValueTotal = 18, dCard1 = "8", bestAction = "SP"},
                new CardHand {pCard1 = "9",pCard2 = "9",SoftValueTotal = 18, HardValueTotal = 18, dCard1 = "9", bestAction = "SP"},
                new CardHand {pCard1 = "9",pCard2 = "9",SoftValueTotal = 18, HardValueTotal = 18, dCard1 = "10", bestAction = "S"},
                new CardHand {pCard1 = "9",pCard2 = "9",SoftValueTotal = 18, HardValueTotal = 18, dCard1 = "A", bestAction = "S"},

                // 10,10 Actions
                new CardHand {pCard1 = "10",pCard2 = "10",SoftValueTotal = 20, HardValueTotal = 20, dCard1 = "2", bestAction = "S"},
                new CardHand {pCard1 = "10",pCard2 = "10",SoftValueTotal = 20, HardValueTotal = 20, dCard1 = "3", bestAction = "S"},
                new CardHand {pCard1 = "10",pCard2 = "10",SoftValueTotal = 20, HardValueTotal = 20, dCard1 = "4", bestAction = "S"},
                new CardHand {pCard1 = "10",pCard2 = "10",SoftValueTotal = 20, HardValueTotal = 20, dCard1 = "5", bestAction = "S"},
                new CardHand {pCard1 = "10",pCard2 = "10",SoftValueTotal = 20, HardValueTotal = 20, dCard1 = "6", bestAction = "S"},
                new CardHand {pCard1 = "10",pCard2 = "10",SoftValueTotal = 20, HardValueTotal = 20, dCard1 = "7", bestAction = "S"},
                new CardHand {pCard1 = "10",pCard2 = "10",SoftValueTotal = 20, HardValueTotal = 20, dCard1 = "8", bestAction = "S"},
                new CardHand {pCard1 = "10",pCard2 = "10",SoftValueTotal = 20, HardValueTotal = 20, dCard1 = "9", bestAction = "S"},
                new CardHand {pCard1 = "10",pCard2 = "10",SoftValueTotal = 20, HardValueTotal = 20, dCard1 = "10", bestAction = "S"},
                new CardHand {pCard1 = "10",pCard2 = "10",SoftValueTotal = 20, HardValueTotal = 20, dCard1 = "A", bestAction = "S"},

                // A,A Actions
                new CardHand {pCard1 = "A",pCard2 = "A",SoftValueTotal = 12, HardValueTotal = 2, dCard1 = "2", bestAction = "SP"},
                new CardHand {pCard1 = "A",pCard2 = "A",SoftValueTotal = 12, HardValueTotal = 2, dCard1 = "3", bestAction = "SP"},
                new CardHand {pCard1 = "A",pCard2 = "A",SoftValueTotal = 12, HardValueTotal = 2, dCard1 = "4", bestAction = "SP"},
                new CardHand {pCard1 = "A",pCard2 = "A",SoftValueTotal = 12, HardValueTotal = 2, dCard1 = "5", bestAction = "SP"},
                new CardHand {pCard1 = "A",pCard2 = "A",SoftValueTotal = 12, HardValueTotal = 2, dCard1 = "6", bestAction = "SP"},
                new CardHand {pCard1 = "A",pCard2 = "A",SoftValueTotal = 12, HardValueTotal = 2, dCard1 = "7", bestAction = "SP"},
                new CardHand {pCard1 = "A",pCard2 = "A",SoftValueTotal = 12, HardValueTotal = 2, dCard1 = "8", bestAction = "SP"},
                new CardHand {pCard1 = "A",pCard2 = "A",SoftValueTotal = 12, HardValueTotal = 2, dCard1 = "9", bestAction = "SP"},
                new CardHand {pCard1 = "A",pCard2 = "A",SoftValueTotal = 12, HardValueTotal = 2, dCard1 = "10", bestAction = "SP"},
                new CardHand {pCard1 = "A",pCard2 = "A",SoftValueTotal = 12, HardValueTotal = 2, dCard1 = "A", bestAction = "SP"},

                // A,2 Actions
                new CardHand {pCard1 = "A",pCard2 = "2",SoftValueTotal = 13, HardValueTotal = 3, dCard1 = "2", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "2",SoftValueTotal = 13, HardValueTotal = 3, dCard1 = "3", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "2",SoftValueTotal = 13, HardValueTotal = 3, dCard1 = "4", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "2",SoftValueTotal = 13, HardValueTotal = 3, dCard1 = "5", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "2",SoftValueTotal = 13, HardValueTotal = 3, dCard1 = "6", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "2",SoftValueTotal = 13, HardValueTotal = 3, dCard1 = "7", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "2",SoftValueTotal = 13, HardValueTotal = 3, dCard1 = "8", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "2",SoftValueTotal = 13, HardValueTotal = 3, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "2",SoftValueTotal = 13, HardValueTotal = 3, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "2",SoftValueTotal = 13, HardValueTotal = 3, dCard1 = "A", bestAction = "H"},

                // A,3 Actions
                new CardHand {pCard1 = "A",pCard2 = "3",SoftValueTotal = 14, HardValueTotal = 4, dCard1 = "2", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "3",SoftValueTotal = 14, HardValueTotal = 4, dCard1 = "3", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "3",SoftValueTotal = 14, HardValueTotal = 4, dCard1 = "4", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "3",SoftValueTotal = 14, HardValueTotal = 4, dCard1 = "5", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "3",SoftValueTotal = 14, HardValueTotal = 4, dCard1 = "6", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "3",SoftValueTotal = 14, HardValueTotal = 4, dCard1 = "7", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "3",SoftValueTotal = 14, HardValueTotal = 4, dCard1 = "8", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "3",SoftValueTotal = 14, HardValueTotal = 4, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "3",SoftValueTotal = 14, HardValueTotal = 4, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "3",SoftValueTotal = 14, HardValueTotal = 4, dCard1 = "A", bestAction = "H"},

                // A,4 Actions
                new CardHand {pCard1 = "A",pCard2 = "4",SoftValueTotal = 15, HardValueTotal = 5, dCard1 = "2", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "4",SoftValueTotal = 15, HardValueTotal = 5, dCard1 = "3", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "4",SoftValueTotal = 15, HardValueTotal = 5, dCard1 = "4", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "4",SoftValueTotal = 15, HardValueTotal = 5, dCard1 = "5", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "4",SoftValueTotal = 15, HardValueTotal = 5, dCard1 = "6", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "4",SoftValueTotal = 15, HardValueTotal = 5, dCard1 = "7", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "4",SoftValueTotal = 15, HardValueTotal = 5, dCard1 = "8", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "4",SoftValueTotal = 15, HardValueTotal = 5, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "4",SoftValueTotal = 15, HardValueTotal = 5, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "4",SoftValueTotal = 15, HardValueTotal = 5, dCard1 = "A", bestAction = "H"},

                // A,5 Actions
                new CardHand {pCard1 = "A",pCard2 = "5",SoftValueTotal = 16, HardValueTotal = 6, dCard1 = "2", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "5",SoftValueTotal = 16, HardValueTotal = 6, dCard1 = "3", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "5",SoftValueTotal = 16, HardValueTotal = 6, dCard1 = "4", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "5",SoftValueTotal = 16, HardValueTotal = 6, dCard1 = "5", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "5",SoftValueTotal = 16, HardValueTotal = 6, dCard1 = "6", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "5",SoftValueTotal = 16, HardValueTotal = 6, dCard1 = "7", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "5",SoftValueTotal = 16, HardValueTotal = 6, dCard1 = "8", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "5",SoftValueTotal = 16, HardValueTotal = 6, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "5",SoftValueTotal = 16, HardValueTotal = 6, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "5",SoftValueTotal = 16, HardValueTotal = 6, dCard1 = "A", bestAction = "H"},

                // A,6 Actions
                new CardHand {pCard1 = "A",pCard2 = "6",SoftValueTotal = 17, HardValueTotal = 7, dCard1 = "2", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "6",SoftValueTotal = 17, HardValueTotal = 7, dCard1 = "3", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "6",SoftValueTotal = 17, HardValueTotal = 7, dCard1 = "4", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "6",SoftValueTotal = 17, HardValueTotal = 7, dCard1 = "5", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "6",SoftValueTotal = 17, HardValueTotal = 7, dCard1 = "6", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "6",SoftValueTotal = 17, HardValueTotal = 7, dCard1 = "7", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "6",SoftValueTotal = 17, HardValueTotal = 7, dCard1 = "8", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "6",SoftValueTotal = 17, HardValueTotal = 7, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "6",SoftValueTotal = 17, HardValueTotal = 7, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "6",SoftValueTotal = 17, HardValueTotal = 7, dCard1 = "A", bestAction = "H"},

                // A,7 Actions
                new CardHand {pCard1 = "A",pCard2 = "7",SoftValueTotal = 18, HardValueTotal = 8, dCard1 = "2", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "7",SoftValueTotal = 18, HardValueTotal = 8, dCard1 = "3", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "7",SoftValueTotal = 18, HardValueTotal = 8, dCard1 = "4", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "7",SoftValueTotal = 18, HardValueTotal = 8, dCard1 = "5", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "7",SoftValueTotal = 18, HardValueTotal = 8, dCard1 = "6", bestAction = "D"},
                new CardHand {pCard1 = "A",pCard2 = "7",SoftValueTotal = 18, HardValueTotal = 8, dCard1 = "7", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "7",SoftValueTotal = 18, HardValueTotal = 8, dCard1 = "8", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "7",SoftValueTotal = 18, HardValueTotal = 8, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "7",SoftValueTotal = 18, HardValueTotal = 8, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "A",pCard2 = "7",SoftValueTotal = 18, HardValueTotal = 8, dCard1 = "A", bestAction = "H"},

                // A,8 Actions
                new CardHand {pCard1 = "A",pCard2 = "8",SoftValueTotal = 19, HardValueTotal = 9, dCard1 = "2", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "8",SoftValueTotal = 19, HardValueTotal = 9, dCard1 = "3", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "8",SoftValueTotal = 19, HardValueTotal = 9, dCard1 = "4", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "8",SoftValueTotal = 19, HardValueTotal = 9, dCard1 = "5", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "8",SoftValueTotal = 19, HardValueTotal = 9, dCard1 = "6", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "8",SoftValueTotal = 19, HardValueTotal = 9, dCard1 = "7", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "8",SoftValueTotal = 19, HardValueTotal = 9, dCard1 = "8", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "8",SoftValueTotal = 19, HardValueTotal = 9, dCard1 = "9", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "8",SoftValueTotal = 19, HardValueTotal = 9, dCard1 = "10", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "8",SoftValueTotal = 19, HardValueTotal = 9, dCard1 = "A", bestAction = "S"},

                // A,9 Actions
                new CardHand {pCard1 = "A",pCard2 = "9",SoftValueTotal = 20, HardValueTotal = 10, dCard1 = "2", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "9",SoftValueTotal = 20, HardValueTotal = 10, dCard1 = "3", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "9",SoftValueTotal = 20, HardValueTotal = 10, dCard1 = "4", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "9",SoftValueTotal = 20, HardValueTotal = 10, dCard1 = "5", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "9",SoftValueTotal = 20, HardValueTotal = 10, dCard1 = "6", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "9",SoftValueTotal = 20, HardValueTotal = 10, dCard1 = "7", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "9",SoftValueTotal = 20, HardValueTotal = 10, dCard1 = "8", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "9",SoftValueTotal = 20, HardValueTotal = 10, dCard1 = "9", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "9",SoftValueTotal = 20, HardValueTotal = 10, dCard1 = "10", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "9",SoftValueTotal = 20, HardValueTotal = 10, dCard1 = "A", bestAction = "S"},

                // A,10 Actions
                new CardHand {pCard1 = "A",pCard2 = "10",SoftValueTotal = 21, HardValueTotal = 11, dCard1 = "2", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "10",SoftValueTotal = 21, HardValueTotal = 11, dCard1 = "3", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "10",SoftValueTotal = 21, HardValueTotal = 11, dCard1 = "4", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "10",SoftValueTotal = 21, HardValueTotal = 11, dCard1 = "5", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "10",SoftValueTotal = 21, HardValueTotal = 11, dCard1 = "6", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "10",SoftValueTotal = 21, HardValueTotal = 11, dCard1 = "7", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "10",SoftValueTotal = 21, HardValueTotal = 11, dCard1 = "8", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "10",SoftValueTotal = 21, HardValueTotal = 11, dCard1 = "9", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "10",SoftValueTotal = 21, HardValueTotal = 11, dCard1 = "10", bestAction = "S"},
                new CardHand {pCard1 = "A",pCard2 = "10",SoftValueTotal = 21, HardValueTotal = 11, dCard1 = "A", bestAction = "S"}
        };


        public List<CardHand> BSMatrix2 = new List<CardHand>
        {
            
                // Total 5-8 Actions, 17+ Actions
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 5, HardValueTotal = 5, dCard1 = "x", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 6, HardValueTotal = 6, dCard1 = "x", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 7, HardValueTotal = 7, dCard1 = "x", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 8, HardValueTotal = 8, dCard1 = "x", bestAction = "H"},

                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 17, HardValueTotal = 17, dCard1 = "x", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 18, HardValueTotal = 18, dCard1 = "x", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 19, HardValueTotal = 19, dCard1 = "x", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 20, HardValueTotal = 20, dCard1 = "x", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 21, HardValueTotal = 21, dCard1 = "x", bestAction = "S"},
                

                // Total 9 Actions
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 9, HardValueTotal = 9, dCard1 = "2", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 9, HardValueTotal = 9, dCard1 = "3", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 9, HardValueTotal = 9, dCard1 = "4", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 9, HardValueTotal = 9, dCard1 = "5", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 9, HardValueTotal = 9, dCard1 = "6", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 9, HardValueTotal = 9, dCard1 = "7", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 9, HardValueTotal = 9, dCard1 = "8", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 9, HardValueTotal = 9, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 9, HardValueTotal = 9, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 9, HardValueTotal = 9, dCard1 = "A", bestAction = "H"},

                // Total 10 Actions
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "2", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "3", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "4", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "5", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "6", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "7", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "8", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "9", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 10, HardValueTotal = 10, dCard1 = "A", bestAction = "H"},

                // Total 11 Actions
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 11, HardValueTotal = 11, dCard1 = "2", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 11, HardValueTotal = 11, dCard1 = "3", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 11, HardValueTotal = 11, dCard1 = "4", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 11, HardValueTotal = 11, dCard1 = "5", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 11, HardValueTotal = 11, dCard1 = "6", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 11, HardValueTotal = 11, dCard1 = "7", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 11, HardValueTotal = 11, dCard1 = "8", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 11, HardValueTotal = 11, dCard1 = "9", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 11, HardValueTotal = 11, dCard1 = "10", bestAction = "D"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 11, HardValueTotal = 11, dCard1 = "A", bestAction = "H"},

                // Total 12 Actions
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "2", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "3", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "4", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "5", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "6", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "7", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "8", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 12, HardValueTotal = 12, dCard1 = "A", bestAction = "H"},

                // Total 13 Actions
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 13, HardValueTotal = 13, dCard1 = "2", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 13, HardValueTotal = 13, dCard1 = "3", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 13, HardValueTotal = 13, dCard1 = "4", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 13, HardValueTotal = 13, dCard1 = "5", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 13, HardValueTotal = 13, dCard1 = "6", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 13, HardValueTotal = 13, dCard1 = "7", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 13, HardValueTotal = 13, dCard1 = "8", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 13, HardValueTotal = 13, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 13, HardValueTotal = 13, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 13, HardValueTotal = 13, dCard1 = "A", bestAction = "H"},

                // Total 14 Actions
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "2", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "3", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "4", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "5", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "6", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "7", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "8", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 14, HardValueTotal = 14, dCard1 = "A", bestAction = "H"},

                // Total 15 Actions
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 15, HardValueTotal = 15, dCard1 = "2", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 15, HardValueTotal = 15, dCard1 = "3", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 15, HardValueTotal = 15, dCard1 = "4", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 15, HardValueTotal = 15, dCard1 = "5", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 15, HardValueTotal = 15, dCard1 = "6", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 15, HardValueTotal = 15, dCard1 = "7", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 15, HardValueTotal = 15, dCard1 = "8", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 15, HardValueTotal = 15, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 15, HardValueTotal = 15, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 15, HardValueTotal = 15, dCard1 = "A", bestAction = "H"},

                // Total 16 Actions
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "2", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "3", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "4", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "5", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "6", bestAction = "S"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "7", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "8", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "9", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "10", bestAction = "H"},
                new CardHand {pCard1 = "x",pCard2 = "x",SoftValueTotal = 16, HardValueTotal = 16, dCard1 = "A", bestAction = "H"}

        };

    }

}
