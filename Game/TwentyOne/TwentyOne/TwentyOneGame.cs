using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Shuffle(Dealer.Deck);
            Console.WriteLine("Place Your Bet");
            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
                player.Balance -= bet;
                     

            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1 && TwentyOneRules.CheckForBlackJack(player.Hand))
                    {
                        Console.WriteLine("BlackJack! {0} wins{1} " ,player.Name, Bets[player]);
                        player.Balance += Convert.ToInt32(Bets[player] * 1.5) + Bets[player];

                        return;
                    }
                }
                Console.WriteLine("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if(i == 1 && TwentyOneRules.CheckForBlackJack(Dealer.Hand))
                {
                    Console.WriteLine("Dealer got blackjack everyone loses");
                    foreach(KeyValuePair<Player, int> entry in Bets)
                    {
                        Dealer.Balance += entry.Value;
                    }
                }
            }
            foreach(Player player in Players)
            {
                while (!player.stay)
                {
                    Console.WriteLine("\n\nDealer's Cards");
                    foreach(Card card in Dealer.Hand)
                    {
                        Console.WriteLine(card.ToString());
                    }
                    Console.WriteLine("\n\nYour Cards");
                    foreach(Card card in player.Hand)
                    {
                    Console.WriteLine(card.ToString());
                    }
                    Console.WriteLine("\n\nHit or Stay");
                    string answer = Console.ReadLine().ToLower();
                    if(answer == "stay")
                    {
                        player.stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.isBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! you lose your bet of {1}. Your balance is now {2}",player.Name,Bets[player], player.Balance);
                        Console.WriteLine("Do you want to continue playing?");
                        answer = Console.ReadLine();
                        if (answer == "yes")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }

                    }

                }
            }
                      
            Dealer.IsBusted = TwentyOneRules.isBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldStay(Dealer.Hand);
            while(!Dealer.IsBusted && !Dealer.Stay)
            {
                Console.WriteLine("Dealer is hitting");
                Dealer.Deal(Dealer.Hand);
                Console.WriteLine("\n\nDealer's Cards");
                foreach (Card card in Dealer.Hand)
                {
                    Console.WriteLine(card.ToString());
                }
             

                Dealer.IsBusted = TwentyOneRules.isBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldStay(Dealer.Hand);

            }
            if (Dealer.Stay) Console.WriteLine("Dealer is Staying");
            if (Dealer.IsBusted)
            {
                Console.WriteLine("Dealer Busted");
                foreach(KeyValuePair<Player,int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += entry.Value * 2;
                }
                return;
            }
            foreach(Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if(playerWon == null)
                {
                    Console.WriteLine("No one wins. Its a push");
                    player.Balance += Bets[player];
                }
                else if(playerWon == true)
                {
                    Console.WriteLine("{0} won {1}", player.Name, Bets[player]);
                    player.Balance += Bets[player] * 2;
                    

                }
                else
                {
                    Console.WriteLine("Dealer Wins");
                    Dealer.Balance += Bets[player];

                }
                Console.WriteLine("Your new balance is {0}", player.Balance);
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if(answer == "yes")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }


        }

        public void WalkAway(Player player)
        {
            player.isActivelyPlaying = false;
        }
    }

    
}  
