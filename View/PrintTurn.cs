using Cesi.SnakeGame.Core;
using Cesi.SnakeGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.View
{
    public class PrintTurn : IView<Player>
    {
        public void Execute(Player arg)
        {
            Console.WriteLine("This is the turn of " + arg.Name);
            Console.WriteLine("You are on the case " + arg.Score);
        }
    }
}
