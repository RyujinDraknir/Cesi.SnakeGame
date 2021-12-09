using Cesi.SnakeGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.View
{
    public class Clear : IView<Object>
    {
        public void Execute(Object arg = null)
        {
            Console.Clear();
        }
    }
}
