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
    public class AskForPlayerAction : IController<int>
    {
        public int Execute()
        {
            ConsoleWriter<string>.Execute(new WriteForInput(), "Press Enter for launching a dice");
            Console.ReadLine();

            Random rd = new Random();
            int ret = rd.Next(1, 6);
            Console.WriteLine("Dice Result : " + ret);
            return ret;
        }
    }
}
