using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class User
    {
        private string name;
        private string login;
        private string password;

        public User(string name, string login, string password)
        {
            this.name = name;
            this.login = login;
            this.password = password;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string Login
        {
            get
            {
                return this.login;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
        }
    }
}
