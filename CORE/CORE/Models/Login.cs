using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Models
{
    internal class Login
    {
        private string _username;
        private string _password;

        public string Password 
        {
            get { return _password; }
            set { _password = value; } 
        }
        public string Username 
        { 
            get { return _username; }
            set { _username = value; } 
        }


        public bool Logar()
        {
            Controllers.Login login = new Controllers.Login();

            return(login.Logando(Username, Password));
        }


    }
}
