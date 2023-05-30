using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Cybergame_managers
{
    public class Employee
    {
        protected int idEmployee;
        protected string nameEmployee;
        protected string passEmp;
        protected string phoneNumber;
        protected Boolean sexualEmp;
        protected DateTime birthEmp;
        protected byte[] imageEmp;
        protected string permission;
        
        public Employee() { }
        
        public Employee(int idEmployee, string nameEmployee, string passEmp, string phoneNumber, Boolean sexualEmp, DateTime birthEmp, byte[] imageEmp, string permission)
        {
            this.idEmployee = idEmployee;
            this.nameEmployee = nameEmployee;
            this.passEmp = passEmp;
            this.phoneNumber = phoneNumber;
            this.sexualEmp = sexualEmp;
            this.birthEmp = birthEmp;
            this.imageEmp = imageEmp;
            this.permission = permission;
        }

        public int IDEmployee
        {
            get { return idEmployee; }
            set { idEmployee = value; }
        }
        public string NameEmployee
        {
            get { return nameEmployee; }
            set { nameEmployee = value; }
        }
        public string PassEmp
        {
            get { return passEmp; }
            set { passEmp = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public Boolean SexualEmp
        {
            get { return sexualEmp; }
            set { sexualEmp = value; }
        }
        public DateTime BirthEmp
        {
            get { return birthEmp; }
            set { birthEmp = value; }
        }
        public byte[] ImageEmp
        {
            get { return imageEmp; }
            set { imageEmp = value; }
        }
        public string Permission
        {
            get { return permission; }
            set { permission = value; }
        }
    }
}
