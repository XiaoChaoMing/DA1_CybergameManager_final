using BUS_Cybergame_managers.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Cybergame_managers
{
    public class chartBUS: IchartBUS
    {
        IImportdetailBUS bllctpn = new ImportdetailBUS();
        IOrderDetailBUS bllcthd = new OrderDetailBUS();
        IOrderBUS bllhd = new OrderBUS();
        public List<dynamic> Tongdaonhthutheothang()
        {
            var kq = from cthd in bllcthd.getAll()
                     join ctpn in bllctpn.getAll() on cthd.IDItem equals ctpn.IDItem
                     join hd in bllhd.getAll() on cthd.IDOder equals hd.IDOrder
                     group new { cthd, ctpn, hd } by hd.timeCre.Month into g
                     select new
                     {
                         Month = g.Key,
                         TotalAmount = g.Sum(x => (x.cthd.PriceItem - x.ctpn.PriceItem) * x.cthd.QuantityItem)
                     };
            var allMonths = Enumerable.Range(1, 12);
            var result = from month in allMonths
                         join data in kq on month equals data.Month into monthData
                         from data in monthData.DefaultIfEmpty()
                         select new
                         {
                             Month = month,
                             TotalAmount = data != null ? data.TotalAmount : 0
                         };
            return result.Cast<dynamic>().ToList();
        }
    }
}
