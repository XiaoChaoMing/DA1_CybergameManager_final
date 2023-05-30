using DTO_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Cybergame_managers.Interface
{
    public interface ICategoryBUS
    {
        int Insert(Categorys ctg);
        int checkItem_ID(int idItem);
        IList<Categorys> getAll();
        int Delete(int idItem);
        int UpdateQuantity(Categorys ctg);
        IList<Categorys> SearchLinq(Categorys ct);
    }
}
