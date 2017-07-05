using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    class Customer
    {

        public Customer(string customerID, string contactName)
        {
            this.customerID = customerID;
            this.contactName = contactName;
        }

        private String customerID;

        public String CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        private string contactName;

        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }
        
    }
}
