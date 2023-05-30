using DTO_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Cybergame_managers.Interface
{
    public interface IOrderBUS
    {
        int Insert(DateTime timecre, int idemp, int idcustomer, decimal money);
        Order GetOrder();
        IList<Order> getAll();
    }
}
