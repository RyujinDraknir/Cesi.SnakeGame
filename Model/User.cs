using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public IUserState State { get; set; }
    }
}
