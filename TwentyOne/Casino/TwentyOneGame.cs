using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.TwentyOne
{
    public class TwentyOneGame : Game , IWalkAway  // inherit from other class
    {
        public TwentyOneDealer Dealer { get; set; }
        public  override void Play()    // override keyword   // The play method
        {
            Dealer = new TwentyOneDealer(); // instantiate new dealer object as a new twentyoneDealer
            foreach(Player player in Players) // players is a property of the game class and its a list of players
            {
                player.Hand = new List<Card>(); // reset players hand
                player.Stay = false; // if true it would carry over and effect next game
            }
            Dealer.Hand = new List<Card>(); // a new hand
            Dealer.Stay = false;
            Dealer.Deck = new Deck(); // a new deck // refresh the deck each round
            Dealer.Deck.Shuffle();
            

            foreach(Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while(!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
                }
                if(bet < 0)
                {
                    throw new FraudException("Security! Kick this person out.");
                }
                bool successfullyBet = player.Bet(bet); // passing amount entered into the bet method
                if(!successfullyBet)
                {
                    return;  // means end this method
                }
                // create a dictionary entry
                Bets[player] = bet; // added to the dictionary
            }
            // Give everyone two cards, loop through the players and give them a card
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach(Player player in Players)
                {
                    Console.Write("{0}: ", player.Name); // console.write = no enter
                    Dealer.Deal(player.Hand); // passing in the players hand
                    if(i == 1) // checking for black jack e.g ace and a face card
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if(blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32(Bets[player] * 1.5 + Bets[player]); // wins 1.5 times his bet + his bet
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if(i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses!");
                        // iterate through the dictionary
                        foreach(KeyValuePair<Player , int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach(Player player in Players)
            {
                while(!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach(Card card in player.Hand)  // check if correct after ********
                    {
                        Console.Write("{0} ", card.ToString()); // showing the player his cards
                    }
                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if(answer == "stay")
                    {
                        player.Stay = true;
                        break; // ends the while loop
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}. ", player.Name, Bets[player],player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if(answer == "yes"|| answer == "yeah")
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
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while(!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if(Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach(KeyValuePair<Player, int> entry in Bets) // Dictionary
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); // where produces a list, first grabs the person
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach(Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); // this boolean can now have a null value
                if(playerWon == null)
                {
                    Console.WriteLine("Push! No one wins");
                    player.Balance += Bets[player]; // give player his cash back
                    
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];

                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
            
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
