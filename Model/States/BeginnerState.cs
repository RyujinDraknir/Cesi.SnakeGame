using Cesi.SnakeGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model.States
{
    public class BeginnerState : AUserState
    {
        public BeginnerState()
        {
            Name = "Beginner";
        }
        public override bool Up(User user)
        {
            user.State = new MediumState();
            return true;
        }


        public override bool Down(User user)
        {
            return false;
        }
    }
}