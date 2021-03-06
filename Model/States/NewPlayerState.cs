using Cesi.SnakeGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model.States
{
    public class NewPlayerState : AUserState
    {
        public NewPlayerState()
        {
            Name = "New Player";
        }
        public override bool Up(User user)
        {
            user.State = new BeginnerState();
            return true;
        }


        public override bool Down(User user)
        {
            return false;
        }
    }
}
