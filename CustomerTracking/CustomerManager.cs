using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerTracking
{
    class CustomerManager 
    {
        public void Add (Customer customer) 
        {
            Console.WriteLine("Müşteri Eklendi : " + "Sn." + customer.Name +" "+ customer.LastName);
                    
        }             
            
        public void Del (Customer customer) 
        {
            Console.WriteLine("Müşteri Bilgileri Silindi : " + "Sn." + customer.Name + " " + customer.LastName);

        }
        public void List (Customer customer)
        {
            Console.WriteLine("Müşteri Listesi : " + "Sn." + customer.Name + " " + customer.LastName);

        }


    }

    
}
