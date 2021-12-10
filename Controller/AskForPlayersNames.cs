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
    public class AskForPlayersNames : IController<List<string>>
    {
        private int playerNumber;

        public AskForPlayersNames(int playerNumber)
        {
            this.playerNumber = playerNumber;
        }

        public List<string> Execute()
        {
            List<string> names = new();
            for(int i = 1; i <= playerNumber; i++)
            {
                string name = "";
                while(name.Trim() == "")
                {
                    ConsoleWriter<string>.Execute(new WriteForInput(), "Enter name of player " + i + " : ");
                    name = Console.ReadLine().Trim();
                }
                names.Add(name);
            }
            ConsoleWriter<Object>.Execute(new Clear(), null);
            return names;
        }
    }
}
