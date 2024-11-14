using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        public Player(string name) : this(name, 100)
        {

        }
        public Player(string name, int beginningBalance) // constructor taking 2 parameters that will assign some values
        {
            Hand = new List<Card>(); // initialise Hand property
            Balance = beginningBalance; // assign to balance
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }

        // bet logic should be in the player class
        public bool Bet(int amount)  // bet method
        {
            if(Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size");
                return false; // bet didnt work
            }
            else
            {
                Balance -= amount;  // Balance = Balance - amount;
                return true;
            }
        }

        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }

    }
}
