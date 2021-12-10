using Cesi.SnakeGame.Core;
using Cesi.SnakeGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.View
{
    public class PrintUpUserState : IView<User>
    {
        public void Execute(User arg)
        {
            Console.WriteLine("User " + arg.UserName + " is now  a " + arg.State.Name + " !!!") ;
        }
    }
}
