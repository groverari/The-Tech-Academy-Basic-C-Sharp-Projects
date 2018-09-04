using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class PLayer
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Nmae { get; set; }
        public bool isActivelyPlaying { get; set; }


    }
}
