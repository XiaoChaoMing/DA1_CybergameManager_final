using BUS_Cybergame_managers.Interface;
using DAL_Cybergame_managers;
using DAL_Cybergame_managers.interfaces;
using DocumentFormat.OpenXml.Bibliography;
using DTO_Cybergame_managers;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Cybergame_managers
{
    public class OrderBUS:IOrderBUS
    {
        IOrderDAL dal = new OrderDAL();
        public int Insert(DateTime timecre,int idemp,int idcustomer,decimal money)
        {
            return dal.Insert(timecre, idemp, idcustomer, money);
        }
        public Order GetOrder()
        {
            Order x = dal.GetOrder();
            return x;
        }
        public IList<Order> getAll()
        {
            System.Data.DataTable table = dal.GetAll();
            IList<Order> list = new List<Order>();
            foreach (DataRow row in table.Rows)
            {
                Order mb = new Order();
                mb.idOrder= row.Field<int>(0);
                mb.TimeCre = row.Field<DateTime>(1);
                mb.idEmployee = row.Field<int>(2);
                mb.idCustomer = row.Field<int>(3);
                mb.Money = row.Field<decimal>(4);
                list.Add(mb);
            }
            return list;
        }
    }
}
