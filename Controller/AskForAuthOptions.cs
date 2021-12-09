using Cesi.SnakeGame.Core;
using Cesi.SnakeGame.Enum;
using Cesi.SnakeGame.Model;
using Cesi.SnakeGame.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Controller
{
    public class AskForAuthOptions : IController<AuthOptions>
    {
        public AuthOptions Execute()
        {
            string response = "0";
            while (response.Trim() != "1" && response.Trim() != "2")
            {
                ConsoleWriter<string>.Execute(new WriteForInput(), "Do you want to Register(1) or Sign In(2) : ");
                response = Console.ReadLine();
                ConsoleWriter<Object>.Execute(new Clear(), null);
            }
            if (response.Trim() == "1")
                return AuthOptions.Register;
            else
                return AuthOptions.Auth;
        }
    }
}
