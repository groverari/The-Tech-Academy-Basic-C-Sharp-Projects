using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneDealer : Dealer
    {
        public bool Stay { get; set; }
        public bool IsBusted { get; set; }
        public List<Card> Hand { get; set; }
        



    }
}
