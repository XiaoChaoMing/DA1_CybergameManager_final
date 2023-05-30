using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Cybergame_managers
{
    public class HistoryPlay
    {
        protected int idHistoryPlay;
        protected int idCustomer;
        protected int idComputer;
        protected DateTime timeStart;
        protected DateTime timeEnd;

        public HistoryPlay() { }
        
        public HistoryPlay(int idHistoryPlay, int idCustomer, int idComputer, DateTime timeStart, DateTime timeEnd)
        {
            this.idHistoryPlay = idHistoryPlay;
            this.idCustomer = idCustomer;
            this.idComputer = idComputer;
            this.timeStart = timeStart;
            this.timeEnd = timeEnd;

        }

        public int IDHistoryPlay
        {
            get { return idHistoryPlay; }
            set { idHistoryPlay = value; }
        }
        public int IDCustomer
        {
            get { return idCustomer; }
            set { idCustomer = value; }
        }
        public int IDComputer
        {
            get { return idComputer; }
            set
            {
                idComputer = value;
            }
        }
        public DateTime TimeStart
        {
            get { return timeStart; }
            set
            {
                timeStart = value;
            }
        }
        public DateTime TimeEnd
        {
            get { return timeEnd; }
            set
            {
                timeEnd = value;
            }
        }
    }
}
