using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Cybergame_managers
{
    public class HistoryFill
    {
        protected int idEmployee;
        protected int idCustomer;
        protected DateTime dateFill;
        protected decimal moneyFill;

        public HistoryFill() { }
        public HistoryFill(int idEmployee,int idCustomer,DateTime dateFill,decimal moneyFill)
        {
            this.idEmployee = idEmployee;
            this.idCustomer = idCustomer;
            this.dateFill = dateFill;
            this.moneyFill = moneyFill;


        }
        public int IDEmployee
        {
            get { return idEmployee; }
            set { idEmployee = value; }
        }
        public int IDCustomer
        {
            get { return idCustomer; }
            set { idCustomer = value; } 
        }
        public DateTime DateFill
        {
            get { return dateFill; }
            set
            {
                dateFill = value;
            }
        }
        public decimal MoneyFill
        {
            get { return moneyFill; }
            set
            {
                moneyFill = value;
            }
        }
    }
}
