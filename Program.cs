using Cesi.SnakeGame.Controller;
using Cesi.SnakeGame.Enum;
using Cesi.SnakeGame.Model;
using System;
using System.Collections.Generic;

namespace Cesi.SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            DbAccess db = DbAccess.GetInstance();

            AuthOptions authOptions = ConsoleAsker<AuthOptions>.Execute(new AskForAuthOptions());

            User user = Auth(db, authOptions);

            Game game = new Game(user, 50, 2, 3);
            game.Start();
        }

        private static User Auth(DbAccess db, AuthOptions authOptions)
        {
            User user = null;
            while (user == null)
            {
                KeyValuePair<string, string> credentials = ConsoleAsker<KeyValuePair<string, string>>.Execute(new AskForCredentials());

                user = db.Users.Find(el => (el.UserName == credentials.Key && el.Password == credentials.Value));

                if (authOptions == AuthOptions.Register)
                {
                    if (user == null)
                    {
                        user = new User(credentials.Key, credentials.Value);
                        db.Users.Add(user);
                    }
                }
                else if (authOptions == AuthOptions.Auth && user == null)
                    Console.WriteLine("");
            }
            return user;
        }
    }
}
