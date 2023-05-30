using BUS_Cybergame_managers.Interface;
using DAL_Cybergame_managers;
using DAL_Cybergame_managers.interfaces;
using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Cybergame_managers
{
    public class AccountBUS:IAccountBUS
    {
        private readonly IAccountDAL dal = new AccountDAL();
        public SqlDataReader checkItem_ID(int idEmployee,string password,string permission)
        {
            return dal.CheckAccount_ID(idEmployee,password,permission);
        }
    }
}
