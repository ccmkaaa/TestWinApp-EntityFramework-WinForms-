using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWinApp.Classes.DALnew
{
    class SingletonConnection
    {
        private static TestDBContext instance;

        private SingletonConnection() { }
        public static TestDBContext GetConnection()
        {
            if (instance == null)
                instance = new TestDBContext();
            return instance;
        }
    }
}
