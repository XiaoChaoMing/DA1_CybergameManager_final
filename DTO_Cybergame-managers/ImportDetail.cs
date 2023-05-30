using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Cybergame_managers
{
    public class ImportDetail
    {
        protected int idImportDetail;
        protected int idImportOder;
        protected int idItem;
        protected decimal priceItem;
        protected int quantityItem;

        public ImportDetail() { }

        public ImportDetail(int idImportDetail, int idImportOder, int idItem, decimal priceItem, int quantityItem)
        {
            this.idImportDetail = idImportDetail;
            this.idImportOder = idImportOder;
            this.idItem = idItem;
            this.priceItem = priceItem;
            this.quantityItem = quantityItem;
        }
        public ImportDetail( int idImportOder, int idItem, decimal priceItem, int quantityItem)
        {
            
            this.idImportOder = idImportOder;
            this.idItem = idItem;
            this.priceItem = priceItem;
            this.quantityItem = quantityItem;
        }
        public int IDImportDetail
        {
            get { return idImportDetail; }
            set { idImportDetail = value; }
        }
        public int IDImportOrder
        {
            get { return idImportOder; }
            set { idImportOder = value; }
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
