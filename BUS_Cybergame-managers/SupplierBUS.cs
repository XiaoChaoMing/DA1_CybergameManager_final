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
    public class SupplierBUS:ISupplierBUS
    {
        ISupplieDAL dal = new SupplieDAL();
        public int CheckCSupp_id(int suppid)
        {
            return dal.CheckCSupp_id(suppid);
        }
        public int Insert(supplier supp)
        {
            if (CheckCSupp_id(supp.IDSupp) == 0)
                return dal.Insert(supp.IDSupp, supp.NameSupp);
            else return -1;

        }
        public IList<supplier> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<supplier> list = new List<supplier>();
            foreach (DataRow row in table.Rows)
            {
                supplier supp = new supplier();
                supp.IDSupp = row.Field<int>(0);
                supp.NameSupp = row.Field<string>(1);
                
                list.Add(supp);
            }
            return list;
        }
    }
}
