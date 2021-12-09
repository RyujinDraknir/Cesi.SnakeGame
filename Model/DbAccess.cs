using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model
{
    public class DbAccess
    {
        private static DbAccess Instance;
        public List<User> Users { get; set; }

        public DbAccess()
        {
            Users = new();
            LoadData();
        }

        public static DbAccess GetInstance()
        {
            if (Instance == null)
                Instance = new DbAccess();
            return Instance;
        }

        public void LoadData()
        {
            Users.Add(new User("michel", "forever"));
            Users.Add(new User("arthur", "laroque"));
        }
    }
}
