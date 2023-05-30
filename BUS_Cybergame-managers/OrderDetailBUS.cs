using BUS_Cybergame_managers.Interface;
using DAL_Cybergame_managers.interfaces;
using DAL_Cybergame_managers;
using DTO_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BUS_Cybergame_managers.Custom_Export;

namespace BUS_Cybergame_managers
{
    public class OrderDetailBUS:IOrderDetailBUS
    {
        IOderDetailDAL dal = new OrderDetailDAL();
        IOrderBUS odbus = new OrderBUS();//hoa don
        ICategoryBUS category = new CategoryBUS();
        public IList<OrderDetail> getAll()
        {
            System.Data.DataTable table = dal.GetAll();
            IList<OrderDetail> list = new List<OrderDetail>();
            foreach (DataRow row in table.Rows)
            {
                OrderDetail mb = new OrderDetail();
                mb.IDOderDetail = row.Field<int>(0);
                mb.IDOder = row.Field<int>(1);
                mb.IDItem = row.Field<int>(2);
                mb.PriceItem = row.Field<decimal>(3);
                mb.QuantityItem = row.Field<int>(4);
                list.Add(mb);
            }
            return list;
        }
        public int Insert(int idorder,int idItem,decimal priceitem,int quantityItem)
        {
            return dal.Insert(idorder, idItem, quantityItem ,priceitem);
        }
        public Order lastHD()
        {
            Order x = odbus.getAll().OrderByDescending(o => o.IDOrder).FirstOrDefault();
            return x;
        }
        public List<dynamic> cthd_sp(int mahd)
        {

            var resultType = (from cthd in this.getAll()
                              join sp in category.getAll()
                              on cthd.IDItem equals sp.IDitem
                              where cthd.IDOder == mahd
                              select new
                              {
                                  TenSP = sp.NameItem,
                                  DVT = sp.DramItem,
                                  SoLuong = cthd.QuantityItem,
                                  DonGia = cthd.PriceItem,

                              });
            return resultType.Cast<dynamic>().ToList();
        }
        public void KetXuatWord(int MaNV, int MaKH, string templatePath, string exportPath)
        {
            var tong = this.getAll().Where(x => (x.IDOder == this.lastHD().IDOrder)).Sum(x => (x.QuantityItem * x.PriceItem));
            int ab = this.lastHD().IDOrder;
            Console.WriteLine(ab);
            List<dynamic> list = this.cthd_sp(ab);
            Console.WriteLine(list);
            Dictionary<string, string> dictionaryData = new Dictionary<string, string>();
            dictionaryData.Add("manv", MaNV.ToString());
            dictionaryData.Add("makh", MaKH.ToString());
            dictionaryData.Add("thanhtien", tong.ToString());
            dictionaryData.Add("ngaylap", DateTime.Now.ToString());
            System.IO.File.Copy(templatePath, exportPath, true);
            ExportDocx.CreateClassTemplate(exportPath, dictionaryData, list);
        }
    }
}
