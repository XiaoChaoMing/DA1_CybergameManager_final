using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Cybergame_managers.Interface
{
    public interface  IAccountBUS
    {
        SqlDataReader checkItem_ID(int idEmployee, string password, string permission);
    }
}
