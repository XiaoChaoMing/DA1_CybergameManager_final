using BUS_Cybergame_managers.Interface;
using DAL_Cybergame_managers;
using DAL_Cybergame_managers.interfaces;
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
    public class HistoryFillBUS : IHistoryFillBUS
    {
        IHistoryFillDAL dal = new HIstoryFillDAL();
        public IList<HistoryFill> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<HistoryFill> list = new List<HistoryFill>();
            foreach (DataRow row in table.Rows)
            {
                HistoryFill h = new HistoryFill();
                h.IDEmployee = row.Field<int>(0);
                h.IDCustomer = row.Field<int>(1);
                h.DateFill = row.Field<DateTime>(2);
                h.MoneyFill = row.Field<decimal>(3);

                list.Add(h);
            }
            return list;
        }
        public int Insert(HistoryFill h)
        {

            return dal.Insert(h.IDEmployee,h.IDCustomer,h.DateFill,h.MoneyFill);


        }
    }
}