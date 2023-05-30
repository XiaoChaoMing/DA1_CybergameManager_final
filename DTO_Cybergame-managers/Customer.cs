using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer
    {
        protected int idCustomer;
        protected string nameCustomer;
        protected string accountCus;
        protected string passwordCus;
        protected decimal moneyCus;
        protected TimeSpan timeLeftCus;
        protected TimeSpan totalTime;
        protected bool status;
        public Customer() { }
        public Customer(Customer C)
        {
            this.idCustomer = C.idCustomer;
            this.nameCustomer = C.nameCustomer;
            this.accountCus = C.accountCus;
            this.passwordCus = C.passwordCus;
            this.moneyCus = C.moneyCus;
            this.timeLeftCus = C.timeLeftCus;
            this.totalTime = C.totalTime;
        }
        public Customer(int idCustomer, string nameCustomer, string accountCus, string passwordCus, decimal moneyCus, TimeSpan timeLeftCus, TimeSpan totalTime, bool status)
        {
            this.idCustomer = idCustomer;
            this.nameCustomer = nameCustomer;
            this.accountCus = accountCus;
            this.passwordCus = passwordCus;
            this.moneyCus = moneyCus;
            this.timeLeftCus = timeLeftCus;
            this.totalTime = totalTime;
            this.status = status;
        }
        public Customer(int idCustomer, string nameCustomer, string accountCus, string passwordCus, decimal moneyCus, TimeSpan timeLeftCus)
        {
            this.idCustomer = idCustomer;
            this.nameCustomer = nameCustomer;
            this.accountCus = accountCus;
            this.passwordCus = passwordCus;
            this.moneyCus = moneyCus;
            this.timeLeftCus = timeLeftCus;
            this.totalTime = new TimeSpan(0);
            this.status = false;
        }
        public int IDCustomer
        {
            get { return idCustomer; }
            set { idCustomer = value; }
        }
        public string NameCustomer
        {
            get { return nameCustomer; }
            set { nameCustomer = value; }
        }
        public string AccountCus
        {
            get { return accountCus; }
            set { accountCus = value; }
        }
        public string PasswordCus
        {
            get { return passwordCus; }
            set { passwordCus = value; }
        }
        public decimal MoneyCus
        {
            get { return moneyCus; }
            set { moneyCus = value; }
        }
        public TimeSpan TimeLeftCus
        {
            get { return timeLeftCus; }
            set
            {
                timeLeftCus = value;
            }
        }
        public TimeSpan TotalTime
        {
            get { return totalTime; }
            set
            {
                totalTime = value;
            }
        }
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
    
}
