using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Player(string name)
        {
            Name = name;
            Score = 1;
        }
    }

    public class CopyOfPlayer
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public CopyOfPlayer(string name)
        {
            Name = name;
            Score = 1;
        }
    }
}
