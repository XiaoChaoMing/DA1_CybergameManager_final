using DAL_Cybergame_managers.helper;
using DAL_Cybergame_managers.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cybergame_managers
{
    public class OrderDetailDAL:IOderDetailDAL
    {
        private const string PARM_IDORDER = "@idOrder";
        private const string PARM_IDITEM = "@idItem";
        private const string PARM_PRICEITEM = "@priceItem";
        private const string PARM_QUANTITYITEM = "@quantityItem";
        public int Insert(int idOrder, int idItem, int quantityItem,decimal priceItem)
        {

            SqlParameter[] parm = new SqlParameter[]
            {

                new SqlParameter(PARM_IDORDER,SqlDbType.Int),
                new SqlParameter(PARM_IDITEM,SqlDbType.Int),
                new SqlParameter(PARM_PRICEITEM,SqlDbType.Decimal),
                new SqlParameter(PARM_QUANTITYITEM,SqlDbType.Int),

            };

            parm[0].Value = idOrder;
            parm[1].Value = idItem;
            parm[2].Value = priceItem;
            parm[3].Value = quantityItem;


            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "CTHD_ins", parm);
        }
        public DataTable GetAll()
        {
            SqlDataReader dra = Sqlhelper.ExecuteReader(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "CTHD_sel_all", null);
            DataTable table = new DataTable();
            table.Columns.Add("idCTHD", typeof(int));
            table.Columns.Add("MaHoaDon", typeof(int));
            table.Columns.Add("MaSP", typeof(int));
            table.Columns.Add("DonGia", typeof(decimal));
            table.Columns.Add("SLBan", typeof(int));
            while (dra.Read())
            {

                table.Rows.Add(int.Parse(dra["idCTHD"].ToString()), int.Parse(dra["MaHoaDon"].ToString()), int.Parse(dra["MaSP"].ToString()), decimal.Parse(dra["DonGia"].ToString()), int.Parse(dra["SLBan"].ToString()));
            }
            dra.Dispose();
            return table;
        }
    }
}
