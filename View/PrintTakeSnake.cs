using Cesi.SnakeGame.Core;
using Cesi.SnakeGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.View
{
    public class PrintTakeSnake : IView<Snake>
    {
        void IView<Snake>.Execute(Snake arg)
        {
            Console.WriteLine("You took a Snake !\n Going to Case : " + arg.End);
        }
    }
}