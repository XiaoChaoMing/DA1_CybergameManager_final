using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cybergame_managers.interfaces
{
    public interface ICustomerDAL
    {
        int Insert(int idCustomer, string nameCustomer, string accountCus, string passwordCus, decimal moneyCus, TimeSpan timeLeftCus);
        int Delete(int idCustomer);
        int Update(int idCustomer, string nameCustomer, string accountCus, string passwordCus, decimal moneyCus, TimeSpan timeLeftCus, TimeSpan totalTime);
        int UpdateMoney(int idCustomer, string nameCustomer, decimal moneyCus, TimeSpan timeLeftCus);
        DataTable getAll();
        DataTable getMember_ID(int idCustomer);
        int checkMember_ID(int idCustomer);
        SqlDataReader CheckAccount_ID(string acc, string password);
        DataTable getCustomer_ID(string acc, string password);
        int UpdateStatus(int idCustomer, bool status);
        int Updatetime(int idCustomer, decimal money, TimeSpan timeleft, TimeSpan totaltime, bool status);
    }
}
