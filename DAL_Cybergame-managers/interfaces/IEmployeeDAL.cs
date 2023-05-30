using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cybergame_managers.interfaces
{
    public interface IEmployeeDAL
    {
        DataTable GetAll();
        int CheckEmployee_ID(int idEmployee);
        int Insert(int idEmployee, string nameEmployee, string passWordEmp, string phoneNumber, Boolean SexualEmp, DateTime BirthEmp, byte[] imageEmp,string Permission);
        int Delete(int idEmployee);
        DataTable getEmployee_ID(int idEmployee);
        int Update(int idEmployee, string nameEmployee, string passWordEmp, string phoneNumber, Boolean SexualEmp, DateTime BirthEmp, byte[] imageEmp, string Permission);
    }
}
