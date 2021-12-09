using Cesi.SnakeGame.Model.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public IUserState State { get; set; }

        public User(string email, string password)
        {
            UserName = email;
            Password = password;
            State = new NewPlayerState();
        }
    }
}
