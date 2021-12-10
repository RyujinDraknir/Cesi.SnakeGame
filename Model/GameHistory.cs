using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model
{
    public class GameHistory
    {
        public DateTime Date { get; set; }
        public List<Player> Players { get; set; }
        public Player Winner { get; set; }
        public List<Snake> Snakes { get; set; }

        public GameHistory(List<Player> players, Player winner, List<Snake> snakes)
        {
            Players = players;
            Winner = winner;
            Snakes = snakes;
            Date = DateTime.UtcNow;
        }
    }
}
