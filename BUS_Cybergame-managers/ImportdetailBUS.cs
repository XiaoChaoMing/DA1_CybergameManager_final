using BUS_Cybergame_managers.Custom_Export;
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
    public class ImportdetailBUS:IImportdetailBUS
    {
        IImportDetailDAL dal = new ImportDetailDAL();//chi tiet phieu nhap
        IImpornOrderBUS impbus = new ImportOrderBUS();// phieu nhap
        IImportOderDAL impdal = new ImportOrderDAL();// phieu nhap
        ICategoryBUS category = new CategoryBUS();
        public int Insert(ImportDetail dt)
        {
            return dal.Insert(dt.IDImportOrder,dt.IDItem,dt.PriceItem,dt.QuantityItem);
        }

        public IList<ImportDetail> getAll()
        {
            {
                System.Data.DataTable table = dal.GetAll();
                IList<ImportDetail> list = new List<ImportDetail>();
                foreach (DataRow row in table.Rows)
                {
                    ImportDetail impd = new ImportDetail();
                    impd.IDImportDetail = row.Field<int>(0);
                    impd.IDImportOrder = row.Field<int>(1);
                    impd.IDItem = row.Field<int>(2);
                    impd.PriceItem = row.Field<decimal>(3);
                    impd.QuantityItem = row.Field<int>(4);
                    
                    list.Add(impd);
                }
                return list;
            }
        }
        public ImportOrder  lastHD()
        {
            ImportOrder x = impbus.getAll().OrderByDescending(o => o.IDImportOrder).FirstOrDefault();
            return x;
        }
        public List<dynamic> cthd_sp(int mahd)
        {

            var resultType = (from cthd in this.getAll()
                              join sp in category.getAll()
                              on cthd.IDItem equals sp.IDitem
                              where cthd.IDImportOrder == mahd
                              select new
                              {
                                  TenSP = sp.NameItem,
                                  DVT = sp.DramItem,
                                  SoLuong = cthd.QuantityItem,
                                  DonGia = cthd.PriceItem,
                                  
                              });
            return resultType.Cast<dynamic>().ToList();
        }
        public void KetXuatWord(int MaNV,int MaKH, string templatePath, string exportPath)
        {
            var tong = this.getAll().Where(x => (x.IDImportOrder == this.lastHD().IDImportOrder)).Sum(x=>(x.QuantityItem*x.PriceItem));
            int ab = this.lastHD().IDImportOrder;
            Console.WriteLine(ab);
            List<dynamic> list = this.cthd_sp(ab);
            Console.WriteLine(list);
            Dictionary<string, string> dictionaryData = new Dictionary<string, string>();
            dictionaryData.Add("manv", MaNV.ToString());
            dictionaryData.Add("mancc", MaKH.ToString());
            dictionaryData.Add("thanhtien", tong.ToString());
            dictionaryData.Add("ngaylap", DateTime.Now.ToString());
            System.IO.File.Copy(templatePath, exportPath, true);
            ExportDocx.CreateClassTemplate(exportPath, dictionaryData, list);
        }
    }
}
