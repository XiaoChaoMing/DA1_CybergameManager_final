using BUS_Cybergame_managers.Interface;
using DAL_Cybergame_managers.interfaces;
using DAL_Cybergame_managers;
using DTO_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Cybergame_managers
{
    public  class ComputerBUS:IComputerBUS
    {
        private readonly IComputerDAL dal = new ComputerDAL();
        public int checkCom_ID(int idCom)
        {
            return dal.CheckCpt_id(idCom);
        }
        public int Insert(Computer cpt)
        {
            if (checkCom_ID(cpt.IDComputer) == 0)
                return dal.Insert(cpt.IDComputer, cpt.IDroom,cpt.NameCom, cpt.StateCom, cpt.ConfigCom);
            else return -1;

        }
        public IList<Computer> getAll()
        {
            System.Data.DataTable table = dal.GetAll();
            IList<Computer> list = new List<Computer>();
            foreach (DataRow row in table.Rows)
            {
                Computer cpt = new Computer();
                cpt.IDComputer = row.Field<int>(0);
                cpt.IDroom = row.Field<int>(1);
                cpt.NameCom= row.Field<string>(2);
                cpt.StateCom = row.Field<string>(3);
                cpt.ConfigCom = row.Field<string>(4);
                
                list.Add(cpt);
            }
            return list;
        }
        public int Delete(int idcom)
        {
            if (checkCom_ID(idcom) != 0)
                return dal.Delete(idcom);
            else return -1;
        }
    }
}
