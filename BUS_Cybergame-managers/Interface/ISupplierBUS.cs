using DTO_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Cybergame_managers.Interface
{
    public interface ISupplierBUS
    {
        int Insert(supplier sup);
        int CheckCSupp_id(int idSupp);
        IList<supplier> getAll();
        
    }
}
