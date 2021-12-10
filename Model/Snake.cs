using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model
{
    public class Snake
    {
        public int Start { get; set; }
        public int End { get; set; }
        public bool IsGoodSnake { get ; set; }
        public Snake(int maxlength, bool isGoodSnake)
        {
            IsGoodSnake = isGoodSnake;
            GenerateSnake(maxlength);
        }
        public Snake(int start, int end)
        {
            Start = start;
            End = end;
            IsGoodSnake = start < end;
        }
        private void GenerateSnake(int maxlength)
        {
            Random random = new Random();
            bool isCorrectDraw  = false;
            int lower = 0;
            int upper = 0;
            while (!isCorrectDraw)
            {
                lower = random.Next(2, maxlength - 3);
                upper = 0;
                if (lower + 2 < maxlength - 1)
                    upper = random.Next(lower + 2, maxlength - 1);
                isCorrectDraw = lower + 1 < upper;
            }

            if (IsGoodSnake)
            {
                Start = lower;
                End = upper;
            } else
            {
                Start = upper;
                End = lower;
            }

        }

    }
}
