using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cybergame_managers.interfaces
{
    public interface IOderDetailDAL
    {
        int Insert(int idOder, int idItem, int quantityItem,decimal priceItem);
        DataTable GetAll();
    }
}
