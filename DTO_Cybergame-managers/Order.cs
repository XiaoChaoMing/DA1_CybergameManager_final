using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Cybergame_managers
{
    public class Order
    {
        public int idOrder;
        public DateTime timeCre;
        public int idEmployee;
        public int idCustomer;
        public decimal money;
        

        public Order() { }

        public Order(int idOrder, DateTime timeCre, int idEmployee, int idCustomer, decimal money)
        {
            this.idOrder = idOrder;
            this.timeCre = timeCre;
            this.idEmployee = idEmployee;
            this.idCustomer = idCustomer;
            this.money = money;
            
        }
        public int IDOrder
        {
            get { return idOrder; }
            set { idOrder = value; }
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
        public decimal Money
        {
            get { return money; }
            set
            {
                money = value;
            }
        }
        public int IDCustomer
        {
            get { return idCustomer; }
            set
            {
                idCustomer = value;
            }
        }

    }
}
