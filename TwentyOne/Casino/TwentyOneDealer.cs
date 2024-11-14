using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneDealer : Dealer // inherits from dealer class
    {
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value;  } }  // The dealers hand
        public bool Stay { get; set; } // stick
        public bool isBusted { get; set; }
    }
}
