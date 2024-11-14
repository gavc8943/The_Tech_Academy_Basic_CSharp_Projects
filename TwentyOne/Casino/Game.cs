using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>(); // an empty list not a null list
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } }

        public  string Name { get; set; }
        public Dictionary<Player, int>  Bets { get {return  _bets; } set { _bets = value; } }  // dictionary property takes a key and a value // value is amount so int is used

        public abstract void Play(); // abstact method only exists in abstract class

        public virtual void ListPlayers()  // virtual methods do have implementation ,abstract dont
        {
            foreach(Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
