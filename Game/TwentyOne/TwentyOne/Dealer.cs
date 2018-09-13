using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            
            Deck.Cards.RemoveAt(0);
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            using (StreamWriter file = new StreamWriter(@"C:\TechAcademy\The-Tech-Academy-Basic-C-Sharp-Projects\Game\TwentyOne\TwentyOne.log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
        }
        public void Shuffle(Deck deck)
        {
            Random rnd = new Random();
            List<Card> temp = new List<Card>();
            for(int i = 0; i<deck.Cards.Count; i++)
            {
                Card c1;
                int n = rnd.Next(deck.Cards.Count);
                c1 = deck.Cards[n];
                temp.Add(c1);
                deck.Cards.RemoveAt(n);
            }
            deck.Cards = temp;
        }


    }
}
