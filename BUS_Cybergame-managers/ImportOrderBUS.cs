using BUS_Cybergame_managers.Interface;
using DAL_Cybergame_managers;
using DAL_Cybergame_managers.interfaces;
using DocumentFormat.OpenXml.Bibliography;
using DTO_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Cybergame_managers
{
    public class ImportOrderBUS:IImpornOrderBUS
    {
        IImportOderDAL dal = new ImportOrderDAL();
        public int Update(decimal totalmoney)
        {
            return dal.Update(totalmoney);
        }
        public int Insert(ImportOrder x)
        {
            return dal.Insert(x.TimeCre, x.IDEmployee, x.IDSupp, x.Money);
        }
        public ImportOrder GetImport()
        {
            return dal.GetImport();
        }
        public IList<ImportOrder> getAll()
        {
            System.Data.DataTable table = dal.GetAll();
            IList<ImportOrder> list = new List<ImportOrder>();
            foreach (DataRow row in table.Rows)
            {
                ImportOrder mb = new ImportOrder();
                mb.IDImportOrder = row.Field<int>(0);
                mb.TimeCre = row.Field<DateTime>(1);
                mb.IDEmployee = row.Field<int>(2);
                mb.IDSupp = row.Field<int>(3);
                mb.Money = row.Field<decimal>(4);
                list.Add(mb);
            }
            return list;
        }
    }
}
