using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Cybergame_managers
{
    public class Account
    {
        protected int idEmployee;
        protected string password;
        protected string permission;

        public Account() { }
        public Account(int idEmployee, string password, string permission)
        {
            this.idEmployee = idEmployee;
            this.Password = password;
            this.permission = permission;
            
        }

        public int IDEmployee
        {
            get { return idEmployee; }
            set { idEmployee = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Permisson
        {
            get { return permission; }
            set
            {
                permission = value;
            }
        }
    }
}
