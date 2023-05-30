using DAL_Cybergame_managers.helper;
using DAL_Cybergame_managers.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cybergame_managers
{
    public class HIstoryFillDAL: IHistoryFillDAL
    {
        private const string PARM_EMPLOYEEID = "@idEmployee";
        private const string PARM_CUSTOMERID = "@idCustomer";
        private const string PARM_DATEFILL = "@dateFill";
        private const string PARM_MONEYFILL = "@moneyFill";
        
        public int Insert(int idEmployee, int idCustomer,  DateTime dateFill, decimal moneyFill)
        {
            SqlParameter[] parm = new SqlParameter[]
            {  
                new SqlParameter(PARM_CUSTOMERID,SqlDbType.Int),
                new SqlParameter(PARM_EMPLOYEEID,SqlDbType.Int),
                new SqlParameter(PARM_DATEFILL,SqlDbType.DateTime),
                new SqlParameter(PARM_MONEYFILL,SqlDbType.Decimal),
                

            };
            parm[0].Value = idCustomer;
            parm[1].Value = idEmployee;
            parm[2].Value = dateFill;
            parm[3].Value = moneyFill;
            
            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "LSN_ins", parm);
        }
        public DataTable getAll()
        {
            SqlDataReader dra = Sqlhelper.ExecuteReader(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "LSN_sel_all", null);
            DataTable table = new DataTable();
            table.Columns.Add("ID nhân viên", typeof(int));
            table.Columns.Add("id thành viên", typeof(int));
            table.Columns.Add("Ngày nạp", typeof(DateTime));
            table.Columns.Add("Số tiền nạp", typeof(decimal));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["idNhanVien"].ToString()), int.Parse(dra["idThanhVien"].ToString()),DateTime.Parse(dra["NgayNap"].ToString()) , decimal.Parse(dra["SoTien"].ToString()));
            }
            dra.Dispose();
            return table;
        }

    }
}
