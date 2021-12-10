using Cesi.SnakeGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model.States
{
    public class SnakeBreakerState : AUserState
    {
        public SnakeBreakerState()
        {
            Name = "Snake Breaker";
        }
        public override bool Up(User user)
        {
            return false;
        }


        public override bool Down(User user)
        {
            return false;
        }
    }
}
