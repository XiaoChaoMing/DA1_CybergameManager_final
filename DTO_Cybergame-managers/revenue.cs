using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Cybergame_managers
{
    public class revenue
    {
        protected int idRevenue;
        protected int idImportDetail;
        protected int idorderDetail;
        protected DateTime timeCre;
        protected decimal Revenue;

        public revenue() { }

        public revenue(int idRevenue, int idImportDetail, int idorderDetail, DateTime timeCre, decimal Revenue)
        {
            this.idRevenue = idRevenue;
            this.idImportDetail = idImportDetail;
            this.idorderDetail = idorderDetail;
            this.timeCre = timeCre;
            this.Revenue = Revenue;
            
        }

        public int IDRevenue
        {
            get { return idRevenue; }
            set { idRevenue = value; }
        }
        public int IDImportDetail
        {
            get { return idImportDetail; }
            set { idImportDetail = value; }
        }
        public int IDOrderDetail
        {
            get { return idorderDetail; }
            set
            {
                idorderDetail = value;
            }
        }
        public DateTime TimeCre
        {
            get { return timeCre; }
            set
            {
                timeCre = value;
            }
        }
        public decimal REVENUE
        {
            get { return Revenue; }
            set
            {
                Revenue = value;
            }
        }

    }
}
