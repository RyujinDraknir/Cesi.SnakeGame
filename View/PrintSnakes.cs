using Cesi.SnakeGame.Core;
using Cesi.SnakeGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.View
{
    public class PrintSnakes : IView<List<Snake>>
    {
        void IView<List<Snake>>.Execute(List<Snake> arg)
        {
            Console.WriteLine("There is " + arg.Count() + " snakes.");
            foreach (Snake snake in arg)
            {
                if (snake.IsGoodSnake)
                    Console.Write("Good ");
                else
                    Console.Write("Bad ");
                Console.WriteLine("Snake at " + snake.Start + " leading to " + snake.End);
            }
        }
    }
}
