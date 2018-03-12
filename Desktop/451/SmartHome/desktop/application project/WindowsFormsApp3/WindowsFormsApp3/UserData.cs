using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class UserData
    {
        public string name;
        public string username;
        public string email;
        public string password;
        public UserData(string username1, string password1, string email1, string name1)
        {
            username = username1;
            password = password1;
            email = email1;
            name = name1;
        }
        public UserData()
        {
            username = "";
            password = "";
            email = "";
            name = "";
        }
    }
}
