using Cesi.SnakeGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Core
{
    public abstract class AUserState : IUserState
    {
        public virtual string Name { get; set; }
        public virtual bool Down(User user)
        {
            return false;
        }

        public virtual bool Up(User user)
        {
            return false;
        }
    }
}
