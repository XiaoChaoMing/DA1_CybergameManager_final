using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Cybergame_managers
{
    public class OrderDetail
    {
        protected int idOderDetail;
        public int idOrder;
        protected int idItem;
        protected decimal priceItem;
        protected int quantityItem;

        public OrderDetail() { }

        public OrderDetail(int idOderDetail, int idOrder, int idItem, decimal priceItem, int quantityItem)
        {
            this.idOderDetail = idOderDetail;
            this.idOrder = idOrder;
            this.idItem = idItem;
            this.priceItem = priceItem;
            this.quantityItem = quantityItem;
        }
        public int IDOderDetail
        {
            get { return idOderDetail; }
            set { idOderDetail = value; }
        }
        public int IDOder
        {
            get { return idOrder; }
            set { idOrder = value; }
        }
        public int IDItem
        {
            get { return idItem; }
            set
            {
                idItem = value;
            }
        }
        public decimal PriceItem
        {
            get { return priceItem; }
            set { priceItem = value; }
        }
        public int QuantityItem
        {
            get { return quantityItem; }
            set
            {
                quantityItem = value;
            }
        }
    }
}
