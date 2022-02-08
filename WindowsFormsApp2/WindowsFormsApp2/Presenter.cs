using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Presenter
    {
        private Model model;

        public Presenter(Model model)
        {
            this.model = model;
        }

        public Model Login(string login, string password)
        {
            login = login.Trim();
            password = password.Trim();

            this.model.Login(login, password);

            return this.model;
        }
    }
}
