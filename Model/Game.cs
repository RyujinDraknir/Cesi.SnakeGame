using Cesi.SnakeGame.Controller;
using Cesi.SnakeGame.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model
{
    public class Game
    {
        private int BoardLength { get; set; }
        private List<Player> Players { get; set; }
        private User User { get; set; }
        private List<Snake> Snakes { get; set; }
        private int NbGoodSnakes { get; set; }
        private int NbBadSnakes { get; set; }
        public Game(User user, int boardlength, int nbGoodSnakes, int nbBadSnakes)
        {
            User = user;
            BoardLength = boardlength;
            NbGoodSnakes = nbGoodSnakes;
            NbBadSnakes = nbBadSnakes;
            Players = new();
            Snakes = new();
        }

        public void Start()
        {
            ConsoleWriter<User>.Execute(new PrintUserState(), User);
            InitBoard();
            Launch();
        }

        private void Launch()
        {
            Player winner = null;
            while(winner == null)
            {
                foreach(Player player in Players)
                {
                    if(winner == null)
                    {
                        PlayerTurn(player);
                        if (player.Score == BoardLength)
                            winner = player;
                    }
                }
            }
            ConsoleWriter<Player>.Execute(new PrintWinner(), winner);

            User.State.Up(User);

            ConsoleWriter<User>.Execute(new PrintUpUserState(), User);

            User.PastGames.Add(new GameHistory(Players, winner, Snakes));
        }

        private void InitBoard()
        {
            int playerNumber = ConsoleAsker<int>.Execute(new AskForPlayerNumber());
            List<string> names = ConsoleAsker<List<string>>.Execute(new AskForPlayersNames(playerNumber));

            foreach (string name in names)
            {
                Players.Add(new Player(name));
            }

            for (int i = 0; i < NbGoodSnakes; i++)
            {
                Snake snake = null;
                while (HasSnakeCollision(snake))
                    snake = new Snake(BoardLength, true);
                Snakes.Add(snake);
            }
            for (int i = 0; i < NbBadSnakes; i++)
            {
                Snake snake = null;
                while (HasSnakeCollision(snake))
                    snake = new Snake(BoardLength, false);
                Snakes.Add(snake);
            }
        }

        private void PlayerTurn(Player player)
        {
            ConsoleWriter<Player>.Execute(new PrintTurn(), player);
            ConsoleWriter<List<Snake>>.Execute(new PrintSnakes(), Snakes);
            int dice = ConsoleAsker<int>.Execute(new AskForPlayerAction());
            player.Score += dice;
            if (player.Score > BoardLength)
            {
                if ((BoardLength % 2) == 0)
                    player.Score = BoardLength / 2;
                else
                    player.Score = (BoardLength + 1) / 2;
            }
            CheckSnakeCollision(player);
            ConsoleAsker<int>.Execute(new AskForPlayerPassTurn());
        }

        private void CheckSnakeCollision(Player player)
        {
            foreach (Snake snake in Snakes)
            {
                if (player.Score == snake.Start)
                {
                    player.Score = snake.End;
                    ConsoleWriter<Snake>.Execute(new PrintTakeSnake(), snake);
                }
            }
        }

        private bool HasSnakeCollision(Snake newSnake)
        {
            bool hasCollision = false;
            if (newSnake != null)
            {

                foreach (Snake snake in Snakes)
                {
                    hasCollision = newSnake.Start == snake.Start || newSnake.Start == snake.End || newSnake.End == snake.Start || newSnake.End == snake.End;
                }
            }
            else
                hasCollision = true;
            return hasCollision;
        }
    }
}
