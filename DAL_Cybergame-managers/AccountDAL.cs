using DAL_Cybergame_managers.helper;
using DAL_Cybergame_managers.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cybergame_managers
{
    public class AccountDAL:IAccountDAL
    {
        private const string PARM_IDEMPLOYEE = "@idEmployee";
        private const string PARM_PASSWORD = "@passEmp";
        private const string PARM_PERMISSION = "@Permission";
        
        public SqlDataReader CheckAccount_ID(int idEmployee, string password, string permisson)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_IDEMPLOYEE,SqlDbType.Int),
                new SqlParameter(PARM_PASSWORD,SqlDbType.VarChar,20),
                new SqlParameter(PARM_PERMISSION,SqlDbType.NVarChar,50)
            };
            parm[0].Value = idEmployee;
            parm[1].Value = password;
            parm[2].Value = permisson;

            return Sqlhelper.ExecuteReader(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "TaiKhoan_check", parm);
        }
    }
}
