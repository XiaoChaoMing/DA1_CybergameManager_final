using DAL_Cybergame_managers.helper;
using DAL_Cybergame_managers.interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using DTO_Cybergame_managers;

namespace DAL_Cybergame_managers
{
    public class EmployeeDAL: IEmployeeDAL
    {
        
        private const string PARM_EMPLOYEEID = "@idEmployee";
        private const string PARM_EMPLOYEENAME = "@nameEmployee";
        private const string PARM_PASSEMP = "@passEmp";
        private const string PARM_PHONENUMBER= "@phoneNumber";
        private const string PARM_SEXUALEMP = "@sexualEmp";
        private const string PARM_BIRTHEMP = "@birthEmp";
        private const string PARM_IMAGEEMP = "@imageEmp";
        private const string PARM_PERMISSION = "@Permission";
        

        public DataTable GetAll()
        {
            SqlDataReader dra = Sqlhelper.ExecuteReader(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "NhanVien_sel_all", null);
            DataTable table = new DataTable();
            table.Columns.Add("idNhanVien", typeof(int));
            table.Columns.Add("Ten", typeof(string));
            table.Columns.Add("SDT", typeof(string));
            table.Columns.Add("GioiTinh", typeof(Boolean));
            table.Columns.Add("NgaySinh", typeof(DateTime));
            table.Columns.Add("HinhAnh", typeof(byte[]));
            table.Columns.Add("MatKhau", typeof(string));
            table.Columns.Add("Quyen", typeof(string));
            while (dra.Read())
            {
                
                table.Rows.Add(int.Parse(dra["idNhanVien"].ToString()), dra["Ten"].ToString(),dra["SDT"].ToString(), bool.Parse(dra["GioiTinh"].ToString()), DateTime.Parse(dra["NgaySinh"].ToString()), (byte[])dra["HinhAnh"], dra["MatKhau"].ToString(), dra["Quyen"].ToString());
            }
            dra.Dispose();
            return table;
        }
        public int CheckEmployee_ID(int idEmployee)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_EMPLOYEEID,SqlDbType.Int)
            };
            parm[0].Value = idEmployee;
            return (int)Sqlhelper.ExecuteScalar(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "NhanVien_check_ID", parm);
        }
        public int Insert(int idEmployee, string nameEmployee, string passWordEmp, string phoneNumber, Boolean SexualEmp, DateTime BirthEmp, byte[] imageEmp, string Permission)
        {
            SqlParameter[] parm = new SqlParameter[]
           {
                new SqlParameter(PARM_EMPLOYEEID,SqlDbType.Int),
                new SqlParameter(PARM_EMPLOYEENAME,SqlDbType.NVarChar,120),
                new SqlParameter(PARM_PASSEMP,SqlDbType.VarChar,20),
                new SqlParameter(PARM_PHONENUMBER,SqlDbType.VarChar,20),
                new SqlParameter(PARM_SEXUALEMP,SqlDbType.Bit),
                new SqlParameter(PARM_BIRTHEMP,SqlDbType.DateTime),
                new SqlParameter(PARM_IMAGEEMP,SqlDbType.Image),
                new SqlParameter(PARM_PERMISSION,SqlDbType.NVarChar,50)

           };
            parm[0].Value = idEmployee;
            parm[1].Value = nameEmployee;
            parm[2].Value = passWordEmp;
            parm[3].Value = phoneNumber;
            parm[4].Value = SexualEmp;
            parm[5].Value = BirthEmp;
            parm[6].Value = imageEmp;
            parm[7].Value = Permission;
            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "NhanVien_ins", parm);
        }
        public int Delete(int IdNhanVien)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_EMPLOYEEID,SqlDbType.Int)
            };
            parm[0].Value = IdNhanVien;

            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "NhanVien_Del", parm);
        }
        public DataTable getEmployee_ID(int idEmployee)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_EMPLOYEEID,SqlDbType.Int)
            };
            parm[0].Value = idEmployee;
            SqlDataReader dra = Sqlhelper.ExecuteReader(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "NhanVien_sel_ID", parm);
            DataTable table = new DataTable();
            table.Columns.Add("idNhanVien", typeof(int));
            table.Columns.Add("Ten", typeof(string));
            table.Columns.Add("SDT", typeof(string));
            table.Columns.Add("GioiTinh", typeof(Boolean));
            table.Columns.Add("NgaySinh", typeof(DateTime));
            table.Columns.Add("HinhAnh", typeof(byte[]));
            table.Columns.Add("MatKhau", typeof(string));
            table.Columns.Add("Quyen", typeof(string));
            while (dra.Read())
            {

                table.Rows.Add(int.Parse(dra["idNhanVien"].ToString()), dra["Ten"].ToString(), dra["SDT"].ToString(), bool.Parse(dra["GioiTinh"].ToString()), DateTime.Parse(dra["NgaySinh"].ToString()), (byte[])dra["HinhAnh"], dra["MatKhau"].ToString(), dra["Quyen"].ToString());
            }
            dra.Dispose();
            return table;
        }
        public int Update(int idEmployee, string nameEmployee, string passWordEmp, string phoneNumber, Boolean SexualEmp, DateTime BirthEmp, byte[] imageEmp, string Permission)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_EMPLOYEEID,SqlDbType.Int),
                new SqlParameter(PARM_EMPLOYEENAME,SqlDbType.NVarChar,120),
                new SqlParameter(PARM_PASSEMP,SqlDbType.VarChar,20),
                new SqlParameter(PARM_PHONENUMBER,SqlDbType.VarChar,20),
                new SqlParameter(PARM_SEXUALEMP,SqlDbType.Bit),
                new SqlParameter(PARM_BIRTHEMP,SqlDbType.DateTime),
                new SqlParameter(PARM_IMAGEEMP,SqlDbType.Image),
                new SqlParameter(PARM_PERMISSION,SqlDbType.NVarChar,50)
            };
            parm[0].Value = idEmployee;
            parm[1].Value = nameEmployee;
            parm[2].Value = passWordEmp;
            parm[3].Value = phoneNumber;
            parm[4].Value = SexualEmp;
            parm[5].Value = BirthEmp;
            parm[6].Value = imageEmp;
            parm[7].Value = Permission;
            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "NhanVien_UPDT", parm);
        }
    }
}
