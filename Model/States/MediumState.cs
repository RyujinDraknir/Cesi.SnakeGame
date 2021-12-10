using Cesi.SnakeGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model.States
{
    public class MediumState : AUserState
    {
        public MediumState()
        {
            Name = "Medium";
        }
        public override bool Up(User user)
        {
            user.State = new ExpertState();
            return true;
        }


        public override bool Down(User user)
        {
            user.State = new BeginnerState();
            return true;
        }
    }
}
