using DAL_Cybergame_managers.helper;
using DAL_Cybergame_managers.interfaces;
using DTO_Cybergame_managers;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Cybergame_managers
{
    public class SupplieDAL:ISupplieDAL
    {
        private const string PARM_SUPPID = "@idSupplier";
        private const string PARM_SUPPNAME = "@nameSupplier";
        public int Insert(int idSupp, string nameSupp)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_SUPPID,SqlDbType.Int),
                new SqlParameter(PARM_SUPPNAME,SqlDbType.NVarChar,30),
                

            };
            parm[0].Value = idSupp;
            parm[1].Value = nameSupp;
            
            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "NhaCC_ins", parm);
        }
        public DataTable getAll()
        {
            SqlDataReader dra = Sqlhelper.ExecuteReader(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "NhaCC_sel", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaNCC", typeof(int));
            table.Columns.Add("TenNCC", typeof(string));
            
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["MaNCC"].ToString()), dra["TenNCC"].ToString());
            }
            dra.Dispose();
            return table;

        }
        public int CheckCSupp_id(int idSupp)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_SUPPID,SqlDbType.Int)
            };
            parm[0].Value = idSupp;
            return (int)Sqlhelper.ExecuteScalar(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "NhaCC_check_id", parm);
        }
    }
}
