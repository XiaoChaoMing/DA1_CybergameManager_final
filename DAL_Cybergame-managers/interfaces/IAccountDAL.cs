using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cybergame_managers.interfaces
{
    public interface IAccountDAL
    {
        SqlDataReader CheckAccount_ID(int idEmployee, string password, string permisson);
    }
}
