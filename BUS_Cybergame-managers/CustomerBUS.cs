using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_Cybergame_managers.Interface;
using Entities;
using DAL_Cybergame_managers;
using DAL_Cybergame_managers.interfaces;
using System.Data.SqlClient;
using System.Data;
using System.Security.Claims;
using DTO_Cybergame_managers;

namespace BUS_Cybergame_managers
{
    public class CustomerBUS : ICustomer
    {
        private readonly ICustomerDAL dal = new CustomerDAL();
        public IList<Customer> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<Customer> list = new List<Customer>();
            foreach (DataRow row in table.Rows)
            {
                Customer mb = new Customer();
                mb.IDCustomer = row.Field<int>(0);
                mb.NameCustomer = row.Field<string>(1);
                mb.AccountCus = row.Field<string>(2);
                mb.PasswordCus = row.Field<string>(3);
                mb.MoneyCus = row.Field<decimal>(4);
                mb.TimeLeftCus = row.Field<TimeSpan>(5);
                mb.TotalTime = row.Field<TimeSpan>(6);
                list.Add(mb);
            }
            return list;
        }
       

        public int checkMember_ID(int customerID)
        {
            return dal.checkMember_ID(customerID);
        }
        public int Insert(Customer mb)
        {
            if (checkMember_ID(mb.IDCustomer) == 0)
                return dal.Insert(mb.IDCustomer, mb.NameCustomer, mb.AccountCus, mb.PasswordCus, mb.MoneyCus, mb.TimeLeftCus);
            else return -1;

        }
        public int UpdateMoney(Customer mb)
        {
            if (checkMember_ID(mb.IDCustomer) != 0)
            {
                return dal.UpdateMoney(mb.IDCustomer,mb.NameCustomer, mb.MoneyCus, mb.TimeLeftCus);
            }
            else return -1;
        }
        public int UpdateStatus(int id,bool status)
        {
            if (checkMember_ID(id) != 0)
            {
                return dal.UpdateStatus(id, status);
            }
            else return -1;
        }
        public int Updatetime(int idCustomer, decimal money, TimeSpan timeleft, TimeSpan totaltime, bool status)
        {
            if (checkMember_ID(idCustomer) != 0)
            {
                return dal.Updatetime(idCustomer, money, timeleft, totaltime, status);
            }
            else return -1;
        }
        public int Delete(int customerID)
        {
            if (checkMember_ID(customerID) != 0)
                return dal.Delete(customerID);
            else return -1;
        }
        public IList<Customer> SearchLinq(Customer mb)
        {
            return getAll().Where(x => (string.IsNullOrEmpty(mb.NameCustomer) || x.NameCustomer.Contains(mb.NameCustomer))
            ).ToList();
        }
       

        public SqlDataReader checkAcount_ID(string acc, string password)
        {
            return dal.CheckAccount_ID(acc, password);
        }
        public Customer getCusTomer_ID(string acc, string password)
        {
            System.Data.DataTable table = dal.getCustomer_ID(acc, password);
                Customer mb = new Customer();
                mb.IDCustomer = table.Rows[0].Field<int>(0);
                mb.NameCustomer = table.Rows[0].Field<string>(1);
                mb.AccountCus = table.Rows[0].Field<string>(2);
                mb.PasswordCus = table.Rows[0].Field<string>(3);
                mb.MoneyCus = table.Rows[0].Field<decimal>(4);
                mb.TimeLeftCus = table.Rows[0].Field<TimeSpan>(5);
                mb.TotalTime = table.Rows[0].Field<TimeSpan>(6);
                mb.Status = table.Rows[0].Field<bool>(7);
            return mb;
            
            
        }
    }
    
}
