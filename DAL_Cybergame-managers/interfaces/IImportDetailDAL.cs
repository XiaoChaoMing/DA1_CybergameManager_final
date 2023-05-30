using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cybergame_managers.interfaces
{
    public interface IImportDetailDAL
    {
        int Insert( int idImportOder, int idItem, decimal priceItem, int quantityItem);
        DataTable GetAll();
    }
}
