using DAL_Cybergame_managers.helper;
using DAL_Cybergame_managers.interfaces;
using DTO_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Security.Policy;

namespace DAL_Cybergame_managers
{
    public class ImportOrderDAL:IImportOderDAL
    {
        private const string PARM_IMPORTORDER = "@idImportOder";
        private const string PARM_TIMECRE = "@timeCre";
        private const string PARM_IDEMPLOYEE = "@idEmployee";
        private const string PARM_ISSUPP = "@idSupp";
        private const string PARM_TOLTALMONEY = "@totalmoney";
        public int Insert( DateTime timeCre, int idEmployee, int idSupp, decimal money)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                
                new SqlParameter(PARM_TIMECRE,SqlDbType.DateTime),
                new SqlParameter(PARM_IDEMPLOYEE,SqlDbType.Int),
                new SqlParameter(PARM_ISSUPP,SqlDbType.Int),
                new SqlParameter(PARM_TOLTALMONEY,SqlDbType.Decimal),
                
            };
            
            parm[0].Value = timeCre;
            parm[1].Value = idEmployee;
            parm[2].Value = idSupp;
            parm[3].Value = money;
            

            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "DHN_ins", parm);
        }
        public int Update( decimal money)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_TOLTALMONEY,SqlDbType.Decimal),
            };

            
            parm[0].Value = money;

            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "DHN_UPDT", parm);
        }

        public ImportOrder GetImport()
        {
            SqlDataReader dra = Sqlhelper.ExecuteReader(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "DHN_sel_last", null);
            ImportOrder x = new ImportOrder();
            while (dra.Read())
            {

                x.IDImportOrder = int.Parse(dra["idDonHangNhap"].ToString());
                x.Money = decimal.Parse(dra["ThanhTien"].ToString());
                
            }
            dra.Dispose();
            return x;
        }
        public DataTable GetAll()
        {
            SqlDataReader dra = Sqlhelper.ExecuteReader(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "DHN_sel_all", null);
            DataTable table = new DataTable();
            table.Columns.Add("idDonHangNhap", typeof(int));
            table.Columns.Add("NgayLap", typeof(DateTime));
            table.Columns.Add("idNhanVien", typeof(int));
            table.Columns.Add("MaNCC", typeof(int));
            table.Columns.Add("ThanhTien", typeof(decimal));
            while (dra.Read())
            {

                table.Rows.Add(int.Parse(dra["idDonHangNhap"].ToString()), DateTime.Parse(dra["NgayLap"].ToString()), int.Parse(dra["idNhanVien"].ToString()), int.Parse(dra["MaNCC"].ToString()), decimal.Parse(dra["ThanhTien"].ToString()));
            }
            dra.Dispose();
            return table;
        }

    }
}
