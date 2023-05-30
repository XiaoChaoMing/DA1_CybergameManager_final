using DTO_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cybergame_managers.interfaces
{
    public interface ISupplieDAL
    {
        int Insert(int idSupp, string nameSupp);
        DataTable getAll();
        int CheckCSupp_id(int idSupp);
    }
}
