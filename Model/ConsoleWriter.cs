using Cesi.SnakeGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model
{
    public static class ConsoleWriter<T>
    {
        public static void Execute(IView<T> view, T content)
        {
            view.Execute(content);
        }
    }
}
