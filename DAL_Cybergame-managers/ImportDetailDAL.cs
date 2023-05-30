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
    public class ImportDetailDAL:IImportDetailDAL
    {
        private const string PARM_ITEMID = "@idImportDetail";
        private const string PARM_NAMEITEM = "@idImportOder";
        private const string PARM_IDCLASSITEM = "@idItem";
        private const string PARM_QUANTITYITEM = "@priceItem";
        private const string PARM_DRAMITEM = "@quantityItem";
        
        public int Insert( int idImportOder, int idItem, decimal priceItem, int quantityItem)
        {

            SqlParameter[] parm = new SqlParameter[]
            {
                
                new SqlParameter(PARM_NAMEITEM,SqlDbType.Int),
                new SqlParameter(PARM_IDCLASSITEM,SqlDbType.Int),
                new SqlParameter(PARM_QUANTITYITEM,SqlDbType.Decimal),
                new SqlParameter(PARM_DRAMITEM,SqlDbType.Int),
                
            };
            
            parm[0].Value = idImportOder;
            parm[1].Value = idItem;
            parm[2].Value = priceItem;
            parm[3].Value = quantityItem;
            

            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "CTHD_nhap_ins", parm);
        }
        public DataTable GetAll()
        {
            SqlDataReader dra = Sqlhelper.ExecuteReader(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "CTHD_nhap_sel", null);
            DataTable table = new DataTable();
            table.Columns.Add("idCTDonHangNhap", typeof(int));
            table.Columns.Add("idDonHangNhap", typeof(int));
            table.Columns.Add("MaSP", typeof(int));
            table.Columns.Add("DonGia", typeof(decimal));
            table.Columns.Add("SLNhap", typeof(int));
            
            while (dra.Read())
            {

                table.Rows.Add(int.Parse(dra["idCTDonHangNhap"].ToString()),int.Parse(dra["idDonHangNhap"].ToString()), int.Parse(dra["MaSP"].ToString()), decimal.Parse(dra["DonGia"].ToString()), int.Parse(dra["SLNhap"].ToString()));
            }
            dra.Dispose();
            return table;
        }
    }
}
