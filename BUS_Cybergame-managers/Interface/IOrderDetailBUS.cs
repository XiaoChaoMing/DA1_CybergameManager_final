using DTO_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Cybergame_managers.Interface
{
    public interface IOrderDetailBUS
    {
        int Insert(int idorder, int idItem, decimal priceitem, int quantityItem);
        IList<OrderDetail> getAll();
        void KetXuatWord(int MaNV, int MaKH, string templatePath, string exportPath);


    }
}
