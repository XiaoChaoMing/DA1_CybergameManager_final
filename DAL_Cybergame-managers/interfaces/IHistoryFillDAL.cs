using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cybergame_managers.interfaces
{
    public interface IHistoryFillDAL
    {
        int Insert(int idEmployee, int idCustomer, DateTime dateFill, decimal moneyFill);
        DataTable getAll();
    }
}
