using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesi.SnakeGame.Model
{
    public class DbAccess
    {
        private static DbAccess Instance;


        private IEnumerable<User> Users;

        public DbAccess()
        {
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

        }
    }
}
