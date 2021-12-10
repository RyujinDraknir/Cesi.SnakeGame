using Cesi.SnakeGame.Core;
using Cesi.SnakeGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.View
{
    public class PrintWinner : IView<Player>
    {
        public void Execute(Player arg)
        {
            Console.WriteLine("Player " + arg.Name + " is the winner !!!");
            Console.ReadLine();
        }
    }
}
