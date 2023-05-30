using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Cybergame_managers
{
    public class Computer
    {
        protected int idComputer;
        protected int idRoom;
        protected string nameCom;
        protected string stateCom;
        protected string configCom;

        public Computer() { }
        public Computer(int idComputer, int idRoom, string nameCom, string stateCom, string configCom)
        {
            this.idComputer = idComputer;
            this.idRoom = idRoom;
            this.nameCom = nameCom;
            this.stateCom = stateCom;
            this.configCom = configCom;
        }

        public int IDComputer
        {
            get { return idComputer; }
            set { idComputer = value; }
        }
        public int IDroom
        {
            get { return idRoom; }
            set
            {
                idRoom = value;
            }
        }
        public string NameCom
        {
            get { return nameCom; }
            set { nameCom = value; }
        }
        public string StateCom
        {
            get { return stateCom; }
            set { stateCom = value; } 
        }
        public string ConfigCom
        {
            get { return configCom; }
            set
            {
                configCom = value;
            }
        }
    }
}
