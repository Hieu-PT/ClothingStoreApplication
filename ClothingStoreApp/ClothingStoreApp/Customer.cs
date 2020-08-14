using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreApp
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(string Username, string Password, string Role)
        {
            username = Username;
            password = Password;
            isRole = Role;
        }
        public Customer(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string username { get; set; }
        public string password { get; set; }
        public string isRole { get; set; }
    }
}
