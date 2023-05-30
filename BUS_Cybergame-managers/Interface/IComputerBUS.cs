using DTO_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Cybergame_managers.Interface
{
    public interface IComputerBUS
    {
        int Insert(Computer cpt);
        int checkCom_ID(int idCom);
        IList<Computer> getAll();
        int Delete(int idCom);
    }
}
