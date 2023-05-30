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
    public class ComputerDAL:IComputerDAL
    {
        private const string PARM_IDCOM = "@idComputer";
        private const string PARM_IDROOM = "@idRoom";
        private const string PARM_NAMECOM = "@nameComputer";
        private const string PARM_STATECOM = "@stateComputer";
        private const string PARM_CONFIGCOM = "@configComputer";

        public DataTable GetAll()
        {
            SqlDataReader dra = Sqlhelper.ExecuteReader(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "May_sel_all", null);
            DataTable table = new DataTable();
            table.Columns.Add("idCom", typeof(int));
            table.Columns.Add("idRoom", typeof(int));
            table.Columns.Add("nameCom", typeof(string));
            table.Columns.Add("stateCom", typeof(string));
            table.Columns.Add("configCom", typeof(string));
            while(dra.Read())
            {
                table.Rows.Add(int.Parse(dra["idMay"].ToString()),int.Parse(dra["idPhong"].ToString()), dra["SoMay"].ToString(), dra["TinhTrang"].ToString(), dra["CauHinh"].ToString());
            }
            dra.Dispose();
            return table;
        }
        public int CheckCpt_id(int idCompuer)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_IDCOM,SqlDbType.Int)
            };
            parm[0].Value = idCompuer;
            return (int)Sqlhelper.ExecuteScalar(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "may_check_id", parm);
        }
        public int Insert(int idCom, int idRoom, string nameCom, string stateCom, string configCom)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_IDCOM,SqlDbType.Int),
                new SqlParameter(PARM_IDROOM,SqlDbType.Int),
                new SqlParameter(PARM_NAMECOM,SqlDbType.VarChar,20),
                new SqlParameter(PARM_STATECOM,SqlDbType.NVarChar,20),
                new SqlParameter(PARM_CONFIGCOM,SqlDbType.NVarChar,1000),
                
            };
            parm[0].Value = idCom;
            parm[1].Value = idRoom;
            parm[2].Value = nameCom;
            parm[3].Value = stateCom;
            parm[4].Value = configCom;
            

            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "May_ins", parm);
        }
        public int Delete(int idCom)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_IDCOM,SqlDbType.Int)
            };
            parm[0].Value = idCom;

            return Sqlhelper.ExecuteNonQuery(Sqlhelper.ConnectionString, CommandType.StoredProcedure, "May_del", parm);
        }
    }
}
