using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cybergame_managers.interfaces
{
    public interface IComputerDAL
    {
        
        DataTable GetAll();
        
        int CheckCpt_id(int idItem);
        int Insert(int idComputer, int idRoom, string nameComputer, string stateComputer, string configComputer);
        int Delete(int idComputer);
    }
}
