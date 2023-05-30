using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Cybergame_managers
{
    public class priceFill
    {
        protected int idprice;
        protected TimeSpan Timepermon;
        protected decimal price;

        public priceFill() { }
        public priceFill(int idprice, TimeSpan timepermon,decimal price)
        {
            this.idprice = idprice;
            this.Timepermon = timepermon;
            this.price = price;

        }
        public int Idprice
        {
            get { return idprice; }
            set { idprice = value; }
        }
        public TimeSpan TimePerMon
        {
            get { return Timepermon; }
            set { Timepermon = value; }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }

    }
}
