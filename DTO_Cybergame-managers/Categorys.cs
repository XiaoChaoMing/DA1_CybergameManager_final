using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Cybergame_managers
{
    public class Categorys
    {
        protected int idItem;
        protected string nameItem;
        protected int idClassItem;
        protected int quantityItem;
        protected string dramItem;
        protected decimal priceItem;
        protected byte[] imageItem;

        public Categorys() { }
        public Categorys(int idItem,string nameItem,int idClassItem,int quantityItem,string dramItem,decimal priceItem, byte[] imageItem)
        {
            this.idItem = idItem;
            this.nameItem = nameItem;
            this.idClassItem = idClassItem;
            this.quantityItem = quantityItem;
            this.dramItem = dramItem;
            this.priceItem = priceItem;
            this.imageItem = imageItem;

        }
        public int IDitem
        {
            get { return idItem; }
            set { idItem = value; }
        }
        public string NameItem
        {
            get { return nameItem; }
            set { nameItem = value; }
        }
        public int IDClassItem
        {
            get { return idClassItem; }
            set
            {
                idClassItem = value;
            }
        }
        public int QuantityItem
        {
            get { return quantityItem; }
            set
            {
                quantityItem = value;
            }
        }
        public string DramItem
        {
            get { return dramItem; }
            set
            {
                dramItem = value;
            }
        }
        public decimal PriceItem
        {
            get { return priceItem; }
            set
            {
                priceItem = value;
            }
        }
        public byte[] ImageItem
        {
            get { return imageItem; }
            set
            {
                imageItem = value;
            }
        }
    }
}
