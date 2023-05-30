using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cybergame_managers.interfaces
{
    public interface ICategorysDAL
    {
        DataTable GetAll();
        int CheckItem_ID(int idComputer);
        int Insert(int idItem, string nameitem, int idClassItem, int quantityItem, string dramItem, decimal priceItem, byte[] imageItem);
        int Delete(int idItem);

        int UpdateQuantity(int idItem,int Soluong);
    }
}
