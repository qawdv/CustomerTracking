using System;

namespace CustomerTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.IdNo = 11111111111;
            customer1.Name =  "Mesut";
            customer1.LastName = "ÖZİL";
            customer1.BirthDay = "19.01.1988" ;

            Customer customer2 = new Customer();
            customer2.IdNo = 22222222222;
            customer2.Name = "Luiz";
            customer2.LastName = "GUSTAVO";
            customer2.BirthDay = "23.11.1976";

            Customer customer3 = new Customer();
            customer3.IdNo = 33333333333;
            customer3.Name = "Dimitrios";
            customer3.LastName = "PELKAS";
            customer3.BirthDay = "01.12.1992";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (Customer customer in customers)

            {
                Console.WriteLine(customer.IdNo);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.BirthDay);
                
                Console.WriteLine("-------------------------------");
            }

            CustomerManager customerAdd = new CustomerManager();
            customerAdd.Add(customer1);
            customerAdd.Add(customer2);
            customerAdd.Add(customer3);

            Console.WriteLine("-------------------------------");

            CustomerManager customerDel = new CustomerManager();
            customerDel.Del(customer1);
            customerDel.Del(customer2);
            customerDel.Del(customer3);

            Console.WriteLine("-------------------------------");

            CustomerManager customerList = new CustomerManager();
            customerList.List(customer1);
            customerList.List(customer2);
            customerList.List(customer3);
        }


    }
}
