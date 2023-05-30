using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Cybergame_managers
{
    public class ImportOrder
    {
        protected int idImportOrder;
        protected DateTime timeCre;
        protected int idEmployee;
        protected int idSupp;
        protected decimal money;
        

        public ImportOrder() { }

        public ImportOrder(int idImportOrder, DateTime timeCre, int idEmployee, int idSupp, decimal money)
        {
            this.idImportOrder = idImportOrder;
            this.timeCre = timeCre;
            this.idEmployee = idEmployee;
            this.idSupp = idSupp;
            this.money = money;
            
        }
        public ImportOrder( DateTime timeCre, int idEmployee, int idSupp, decimal money)
        {
            
            this.timeCre = timeCre;
            this.idEmployee = idEmployee;
            this.idSupp = idSupp;
            this.money = money;

        }
        public int IDImportOrder
        {
            get { return idImportOrder; }
            set { idImportOrder = value; }
        }
        public DateTime TimeCre
        {
            get { return timeCre; }
            set { timeCre = value; }
        }
        public int IDEmployee
        {
            get { return idEmployee; }
            set
            {
                idEmployee = value;
            }
        }
        public int IDSupp
        {
            get { return idSupp; }
            set
            {
                idSupp = value;
            }
        }
        public decimal Money
        {
            get { return money; }
            set
            {
                money = value;
            }
        }
       
    }
}
