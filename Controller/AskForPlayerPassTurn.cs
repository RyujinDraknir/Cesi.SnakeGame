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
    public class AskForPlayerPassTurn : IController<int>
    {
        public int Execute()
        {

            ConsoleWriter<string>.Execute(new WriteForInput(), "Press Enter to Continue...");
            Console.ReadLine();

            ConsoleWriter<Object>.Execute(new Clear(), null);
            return 0;
        }
    }
}
