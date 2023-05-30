using DAL_Cybergame_managers.interfaces;
using DAL_Cybergame_managers;
using DocumentFormat.OpenXml.Bibliography;
using DTO_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_Cybergame_managers.Interface;
using System.Data;
using Entities;

namespace BUS_Cybergame_managers
{
    public class CategoryBUS:ICategoryBUS
    {
        private readonly ICategorysDAL dal = new CategoryDAL();
        public int checkItem_ID(int idItem)
        {
            return dal.CheckItem_ID(idItem);
        }
        public int Insert(Categorys ctg)
        {
            if (checkItem_ID(ctg.IDitem) == 0)
                return dal.Insert(ctg.IDitem,ctg.NameItem,ctg.IDClassItem,ctg.QuantityItem,ctg.DramItem,ctg.PriceItem,ctg.ImageItem);
            else return -1;

        }
        public IList<Categorys> getAll()
        {
            System.Data.DataTable table = dal.GetAll();
            IList<Categorys> list = new List<Categorys>();
            foreach (DataRow row in table.Rows)
            {
                Categorys ctg = new Categorys();
                ctg.IDitem = row.Field<int>(0);
                ctg.NameItem = row.Field<string>(1);
                ctg.IDClassItem= row.Field<int>(2);
                ctg.QuantityItem = row.Field<int>(3);
                ctg.DramItem = row.Field<string>(4);
                ctg.PriceItem = row.Field<decimal>(5);
                ctg.ImageItem = row.Field<byte[]>(6);
                list.Add(ctg);
            }
            return list;
        }
        public int Delete(int idItem)
        {
            if (checkItem_ID(idItem) != 0)
                return dal.Delete(idItem);
            else return -1;
        }
        public int UpdateQuantity(Categorys ctg)
        {
            if (checkItem_ID(ctg.IDitem) != 0)
            {
                return dal.UpdateQuantity(ctg.IDitem,ctg.QuantityItem);
            }
            else return -1;
        }
        public IList<Categorys> SearchLinq(Categorys ct)
        {
            return getAll().Where(x => ((string.IsNullOrEmpty(ct.NameItem) || x.NameItem.Contains(ct.NameItem)
            || (ct.IDClassItem==null||x.IDClassItem == ct.IDClassItem)))
            ).ToList();
        }
    }
}
