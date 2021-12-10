using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model
{
    public interface IUserState
    {
        public bool Up(User user);
        public bool Down(User user);
    }
}
