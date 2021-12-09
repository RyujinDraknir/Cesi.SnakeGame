using Cesi.SnakeGame.Core;
using Cesi.SnakeGame.Model;
using Cesi.SnakeGame.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Controller
{
    public class AskForCredentials : IController<KeyValuePair<string, string>>
    {
        public KeyValuePair<string, string> Execute()
        {
            string username = "";
            string password = "";

            while(username.Trim() == "")
            {
                ConsoleWriter<string>.Execute(new WriteForInput(), "Enter your UserName : ");
                username = Console.ReadLine();
                ConsoleWriter<Object>.Execute(new Clear(), null);
            }

            while (password.Trim() == "")
            {
                ConsoleWriter<string>.Execute(new WriteForInput(), "Enter your Password : ");
                password = Console.ReadLine();
                ConsoleWriter<Object>.Execute(new Clear(), null);
            }
            return KeyValuePair.Create(username,password);
        }
    }
}
