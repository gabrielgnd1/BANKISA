using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISA_BANK.DB_CLASS
{
    public class Akun
    {
        private int id;
        private string username;
        private string password;
        private string roles;

        public Akun() { }

        public Akun(int id, string username, string password, string roles)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.roles = roles;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Roles { get => roles; set => roles = value; }

        #region Methods

        #endregion
    }
}
