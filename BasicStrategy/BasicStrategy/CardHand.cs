using System;
using System.Collections.Generic;
using System.Text;

namespace BasicStrategy
{
    public class CardHand
    {  
        public string pCard1 { get; set; }
        public string pCard2 { get; set; }
        public int HardValueTotal { get; set; }
        public int SoftValueTotal { get; set; }
        public string dCard1 { get; set; }
        public string bestAction { get; set; }


        public static int sValue(Card x, Card y)
        {
            return (x.SoftValue + y.SoftValue);

        }

        public static int hValue(Card x, Card y)
        {
            return (x.HardValue + y.HardValue);
        }

        
       

    }
}
