using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Model
    {
        private List<User> users;
        private User loggedUser;
        private User loggedPas;

        public Model()
        {
            users = new List<User>();

            users.Add(new User("23шт", "Принтер", "password1"));
            users.Add(new User("10шт", "Сканер", "password2"));
            users.Add(new User("Name3", "Login3", "password3"));
            users.Add(new User("Name4", "Login4", "password4"));

            loggedUser = null;
            loggedPas = null;
        }

  

        public string vibor(string ss)
        {
            string rez = null;
            if (ss == "Принтер")
            {
                rez = "15 рублей";
            }
                
            if (ss == "Сканер")
            {
                rez = "50 рублей";
            }
            return rez;
                

        }

        public void Login(string login, string password)
        {
            bool hasLogged = false;

            foreach(User user in this.users)
            {
                if(user.Login == login && user.Password == password)
                {
                    this.loggedUser = user;
                    this.loggedPas = password;


                    hasLogged = true;
                    break;
                }
            }

            if (!hasLogged)
            {
                this.loggedUser = null;
            }
        }

        public string Message
        {
            get
            {
                return this.loggedUser != null ? $"Имеется {this.loggedUser.Name}!, цена:" +vibor("Принтер") : "Неверные данные для входа!";
            }
        }
        
    }


}
