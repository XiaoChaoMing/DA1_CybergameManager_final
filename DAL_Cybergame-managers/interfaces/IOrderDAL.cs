using DTO_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cybergame_managers.interfaces
{
    public interface IOrderDAL
    {
        int Insert(DateTime timeCre, int idEmployee, int idCustomer, decimal money);
        Order GetOrder();
        DataTable GetAll();
    }
}
