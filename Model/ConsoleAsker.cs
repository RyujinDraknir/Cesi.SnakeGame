using Cesi.SnakeGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model
{
    public class ConsoleAsker<T>
    {
        public static T Execute(IController<T> controller)
        {
            return controller.Execute();
        }
    }
}
