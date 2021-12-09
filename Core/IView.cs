using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Core
{
    public interface IView<T>
    {
        public void Execute(T arg);
    }
}
