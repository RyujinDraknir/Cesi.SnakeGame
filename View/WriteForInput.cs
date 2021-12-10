using Cesi.SnakeGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.View
{
    public class WriteForInput : IView<string>
    {
        public void Execute(string arg)
        {
            Console.Write(arg);
        }
    }

    public class CopyOfWriteForInput : IView<string>
    {
        public void Execute(string arg)
        {
            Console.Write(arg);
        }
    }
}
