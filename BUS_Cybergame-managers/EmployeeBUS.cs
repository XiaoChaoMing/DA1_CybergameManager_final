using BUS_Cybergame_managers.Interface;
using DAL_Cybergame_managers.interfaces;
using DAL_Cybergame_managers;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Cybergame_managers;
using System.Data;
using DocumentFormat.OpenXml.Spreadsheet;

namespace BUS_Cybergame_managers
{
    public class EmployeeBUS:IEmployeeBUS
    {
        private readonly IEmployeeDAL dal = new EmployeeDAL();
        public int checkEmployee_ID(int EmployeeID)
        {
            return dal.CheckEmployee_ID(EmployeeID);
        }
        public int Insert(Employee emp)
        {
            if (checkEmployee_ID(emp.IDEmployee) == 0)
                return dal.Insert(emp.IDEmployee, emp.NameEmployee, emp.PassEmp, emp.PhoneNumber, emp.SexualEmp, emp.BirthEmp,emp.ImageEmp,emp.Permission);
            else return -1;

        }
        public IList<Employee> getAll()
        {
            System.Data.DataTable table = dal.GetAll();
            IList<Employee> list = new List<Employee>();
            foreach (DataRow row in table.Rows)
            {
                Employee emb = new Employee();
                emb.IDEmployee = row.Field<int>(0);
                emb.NameEmployee = row.Field<string>(1); 
                emb.PhoneNumber = row.Field<string>(2);
                emb.SexualEmp = row.Field<Boolean>(3);
                emb.BirthEmp = row.Field<DateTime>(4);
                emb.ImageEmp = row.Field<byte[]>(5);
                emb.PassEmp = row.Field<string>(6);
                emb.Permission = row.Field<string>(7);
                list.Add(emb);
            }
            return list;
        }
        public int Delete(int idNhanvien)
        {
            if (checkEmployee_ID(idNhanvien) != 0)
                return dal.Delete(idNhanvien);
            else return -1;
        }
        public Employee getEmployee_ID(int EmployeeID)
        {
            System.Data.DataTable table = dal.getEmployee_ID(EmployeeID);
            if (checkEmployee_ID(EmployeeID) != 0)
            {
                Employee emb = new Employee();
                emb.IDEmployee = table.Rows[0].Field<int>(0);
                emb.NameEmployee = table.Rows[0].Field<string>(1);
                emb.PhoneNumber = table.Rows[0].Field<string>(2);
                emb.SexualEmp = table.Rows[0].Field<Boolean>(3);
                emb.BirthEmp = table.Rows[0].Field<DateTime>(4);
                emb.ImageEmp = table.Rows[0].Field<byte[]>(5);
                emb.PassEmp = table.Rows[0].Field<string>(6);
                emb.Permission = table.Rows[0].Field<string>(7);
                return emb;
            }
            else return null;
        }
        public int Update(Employee emb)
        {
            if (checkEmployee_ID(emb.IDEmployee) != 0)
            {
                return dal.Update(emb.IDEmployee,emb.NameEmployee,emb.PassEmp,emb.PhoneNumber,emb.SexualEmp,emb.BirthEmp,emb.ImageEmp,emb.Permission);
            }
            else return -1;
        }
    }
}
