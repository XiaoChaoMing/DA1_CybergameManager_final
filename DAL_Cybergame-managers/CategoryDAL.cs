using DAL_Cybergame_managers.helper;
using DAL_Cybergame_managers.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cybergame_managers
{
    public class CategoryDAL:ICategorysDAL
    {
        private const string PARM_ITEMID = "@idItem";
        private const string PARM_NAMEITEM = "@nameItem";
        private const string PARM_IDCLASSITEM = "@idClassitem";
        private const string PARM_QUANTITYITEM = "@quantityItem";
        private const string PARM_DRAMITEM = "@dramItem";
        private const string PARM_PRICEITEM = "@priceItem";
        private const string PARM_IMAGEITEM = "@imageItem";
        
        public DataTable GetAll()
        {
            SqlDataReader dra = Sqlhelper.ExecuteReader(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "SanPham_sel_all", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaSP", typeof(int));
            table.Columns.Add("TenSP", typeof(string));
            table.Columns.Add("MaLoaiSP", typeof(int));
            table.Columns.Add("SoLuong", typeof(int));
            table.Columns.Add("DonVi", typeof(string));
            table.Columns.Add("GiaBan", typeof(decimal));
            table.Columns.Add("HinhAnh", typeof(byte[]));
            while (dra.Read())
            {

                table.Rows.Add(int.Parse(dra["MaSP"].ToString()), dra["TenSP"].ToString(), int.Parse(dra["MaLoaiSP"].ToString()), int.Parse(dra["SoLuong"].ToString()), dra["DonVi"].ToString(), decimal.Parse(dra["GiaBan"].ToString()),(byte[])dra["HinhAnh"]);
            }
            dra.Dispose();
            return table;
        }
        public int CheckItem_ID(int idItem)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_ITEMID,SqlDbType.Int)
            };
            parm[0].Value = idItem;
            return (int)Sqlhelper.ExecuteScalar(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "SanPham_Check_ID", parm);
        }
        public int Insert(int idItem, string nameitem, int idClassItem, int quantityItem, string dramItem, decimal priceItem, byte[] imageItem)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_ITEMID,SqlDbType.Int),
                new SqlParameter(PARM_NAMEITEM,SqlDbType.NVarChar,100),
                new SqlParameter(PARM_IDCLASSITEM,SqlDbType.Int),
                new SqlParameter(PARM_QUANTITYITEM,SqlDbType.Int),
                new SqlParameter(PARM_DRAMITEM,SqlDbType.NVarChar,40),
                new SqlParameter(PARM_PRICEITEM,SqlDbType.Decimal),
                new SqlParameter(PARM_IMAGEITEM,SqlDbType.Image),
            };
            parm[0].Value = idItem;
            parm[1].Value = nameitem;
            parm[2].Value = idClassItem;
            parm[3].Value = quantityItem;
            parm[4].Value = dramItem;
            parm[5].Value = priceItem;
            parm[6].Value = imageItem;
           
            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "SanPham_ins", parm);
        }
        public int UpdateQuantity(int idItem,int quantity)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_ITEMID,SqlDbType.Int),
                new SqlParameter(PARM_QUANTITYITEM,SqlDbType.Int)
            };

            parm[0].Value = idItem;
            parm[1].Value = quantity;
            

            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "SanPham_UPDT_sl", parm);
        }
        public int Delete(int idItem)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_ITEMID,SqlDbType.Int)
            };
            parm[0].Value = idItem;

            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "SanPham_del", parm);
        }
    }
}
