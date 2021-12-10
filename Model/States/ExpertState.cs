using Cesi.SnakeGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model.States
{
    public class ExpertState : AUserState
    {
        public ExpertState()
        {
            Name = "Expert";
        }
        public override bool Up(User user)
        {
            user.State = new SnakeBreakerState();
            return true;
        }


        public override bool Down(User user)
        {
            user.State = new MediumState();
            return false;
        }
    }
}
