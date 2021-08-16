using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.firstName+" kişisi eklendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.firstName+" kişisi silindi.");
        }

        public void Listed(Customer[] customers) {


            foreach (var musteri in customers)
            {
                Console.WriteLine(musteri.firstName);
                Console.WriteLine(musteri.lastName);

            }

        }
    }
}
