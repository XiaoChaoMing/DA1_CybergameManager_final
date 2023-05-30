using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Cybergame_managers
{
    public class supplier
    {
        protected int idSupp;
        protected string nameSupp;

        public supplier() { }
        public supplier(int idSupp,string nameSup)
        {
            this.idSupp = idSupp;
            this.nameSupp = nameSup;

        }
        public int IDSupp
        {
            get { return idSupp; }
            set { idSupp = value; }
        }
        public string NameSupp
        {
            get { return nameSupp; }
            set { nameSupp = value; }
        }
    }
}
