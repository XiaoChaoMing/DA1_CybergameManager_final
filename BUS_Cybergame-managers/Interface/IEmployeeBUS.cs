using DTO_Cybergame_managers;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Cybergame_managers.Interface
{
    public interface IEmployeeBUS
    {
        int Insert(Employee emp);
        int checkEmployee_ID(int EmployeeID);
        IList<Employee> getAll();
        int Delete(int idNhanvien);
        Employee getEmployee_ID(int EmployeeID);
        int Update(Employee emb);
    }
}
