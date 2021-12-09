using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model
{
    public class Game
    {
        public Game(User user)
        {
            User = user;
        }

        private User User { get; set; }
    }
}
