using DAL_Cybergame_managers.helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Cybergame_managers.interfaces;
using DTO_Cybergame_managers;

namespace DAL_Cybergame_managers
{
    public class OrderDAL:IOrderDAL
    {
        private const string PARM_IMORDER = "@idOrder";
        private const string PARM_TIMECRE = "@timeCre";
        private const string PARM_IDEMPLOYEE = "@idEmployee";
        private const string PARM_IDCUSTOMER = "@idCustomer";
        private const string PARM_TOLTALMONEY = "@totalmoney";
        public int Insert(DateTime timeCre, int idEmployee, int idCustomer, decimal money)
        {
            SqlParameter[] parm = new SqlParameter[]
            {

                new SqlParameter(PARM_TIMECRE,SqlDbType.DateTime),
                new SqlParameter(PARM_IDEMPLOYEE,SqlDbType.Int),
                new SqlParameter(PARM_IDCUSTOMER,SqlDbType.Int),
                new SqlParameter(PARM_TOLTALMONEY,SqlDbType.Decimal),

            };

            parm[0].Value = timeCre;
            parm[1].Value = idEmployee;
            parm[2].Value = idCustomer;
            parm[3].Value = money;


            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "HoaDon_ins", parm);
        }
        public Order GetOrder()
        {
            SqlDataReader dra = Sqlhelper.ExecuteReader(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "HoaDon_sel_last", null);
            Order x = new Order();
            while (dra.Read())
            {

                x.IDOrder = int.Parse(dra["MaHoaDon"].ToString());
                

            }
            dra.Dispose();
            return x;
        }
        public DataTable GetAll()
        {
            SqlDataReader dra = Sqlhelper.ExecuteReader(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "HoaDon_sel_all", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaHoaDon", typeof(int));
            table.Columns.Add("NgayLap", typeof(DateTime));
            table.Columns.Add("idNhanVien", typeof(int));
            table.Columns.Add("idThanhVien", typeof(int));
            table.Columns.Add("ThanhTien", typeof(decimal));
            while (dra.Read())
            {

                table.Rows.Add(int.Parse(dra["MaHoaDon"].ToString()),DateTime.Parse(dra["NgayLap"].ToString()), int.Parse(dra["idNhanVien"].ToString()), int.Parse(dra["idThanhVien"].ToString()), decimal.Parse(dra["ThanhTien"].ToString()));
            }
            dra.Dispose();
            return table;
        }
    }
}
