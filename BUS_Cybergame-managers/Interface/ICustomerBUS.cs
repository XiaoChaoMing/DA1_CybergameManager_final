using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Cybergame_managers.Interface
{
    public interface ICustomer
    {
        IList<Customer> getAll();
        
        int UpdateMoney(Customer customer);
        int Insert(Customer customer);
        int checkMember_ID(int customerID);
        int Delete(int customerID);
        IList<Customer> SearchLinq(Customer mb);
        SqlDataReader checkAcount_ID(string acc, string password);
        Customer getCusTomer_ID(string acc, string password);
        int UpdateStatus(int id, bool status);
        int Updatetime(int idCustomer, decimal money, TimeSpan timeleft, TimeSpan totaltime, bool status);

    }
}
