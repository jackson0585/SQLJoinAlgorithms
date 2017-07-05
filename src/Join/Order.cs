using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    class Order
    {

        public Order(int orderID, string customerID)
        {
            this.orderID = orderID;
            this.customerID = customerID;
        }

        private int orderID;

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        private string customerID;

        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        
    }
}
