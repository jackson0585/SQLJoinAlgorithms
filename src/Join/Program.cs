using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    class Program
    {
        private static Collection<Customer> customers = new Collection<Customer>();
        private static Collection<Order> orders = new Collection<Order>();
        private static Collection<int> orderIDs = new Collection<int>();
        private static int customExecuteCount = 0;
        private static int orderExecuteCount = 0;
        public static void InitCustomers()
        {
            customers.Add(new Customer("ALFKI", "Maria Anders"));
            customers.Add(new Customer("DRACD", "Sven Ottlieb"));
            customers.Add(new Customer("FRANK", "Peter Franken"));
            customers.Add(new Customer("SAVEA", "Jose Pavarotti"));
            customers.Add(new Customer("TORTU", "Miguel Angel Paolino"));
        }

        public static void InitOrders()
        {
            orders.Add(new Order(10702, "ALFKI"));
            orders.Add(new Order(10835, "ALFKI"));
            orders.Add(new Order(10952, "ALFKI"));
            orders.Add(new Order(10560, "FRANK"));
            orders.Add(new Order(10653, "FRANK"));
            orders.Add(new Order(11012, "FRANK"));
            orders.Add(new Order(10452, "SAVEA"));
            orders.Add(new Order(10643, "ALFKI"));
            orders.Add(new Order(10692, "ALFKI"));
            
        }


        static void Main(string[] args)
        {
            InitCustomers();
            InitOrders();
            foreach(Customer customer in customers )
            {
                customExecuteCount++;
                foreach(Order order in orders)
                {
                    orderExecuteCount++;
                    if(customer.CustomerID == order.CustomerID)
                    {
                        orderIDs.Add(order.OrderID);
                    }
                }
            }

            Console.WriteLine(string.Format("customExecuteCount: {0}",customExecuteCount));
            Console.WriteLine(string.Format("orderExecuteCount: {0}", orderExecuteCount));

            foreach(int orderID in orderIDs)
            {
                Console.WriteLine(orderID);
            }

            Console.ReadKey();

            customExecuteCount = 0;
            orderExecuteCount = 0;
            foreach (Order order in orders) 
            {
                orderExecuteCount++;
                foreach (Customer customer in customers)
                {
                    customExecuteCount++;
                    if (customer.CustomerID == order.CustomerID)
                    {
                        
                        orderIDs.Add(order.OrderID);
                    }
                }
            }

            Console.WriteLine(string.Format("customExecuteCount: {0}", customExecuteCount));
            Console.WriteLine(string.Format("orderExecuteCount: {0}", orderExecuteCount));

            foreach (int orderID in orderIDs)
            {
                Console.WriteLine(orderID);
            }
            Console.ReadKey();
        }
    }
}
