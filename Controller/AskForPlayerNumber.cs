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
    public class AskForPlayerNumber : IController<int>
    {
        public int Execute()
        {
            int ret = 0;
            while (!(ret > 1 && 6 > ret))
            {
                try
                {
                    ConsoleWriter<string>.Execute(new WriteForInput(), "Enter the number of players between 2 and 5 : ");
                    ret = int.Parse(Console.ReadLine());
                }catch { }
            }
            ConsoleWriter<Object>.Execute(new Clear(), null);
            return ret;
        }
    }
}
