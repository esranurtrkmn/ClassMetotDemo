using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.firstName = "Esranur";
            customer.lastName = "Türkmen";

            Customer customer2 = new Customer();
            customer2.firstName = "Deneme";
            customer2.lastName = "Deneme2";

            Customer[] customers = new Customer[] {customer, customer2 };

           

            CustomerManager cmManager = new CustomerManager();

            cmManager.Add(customer);
            cmManager.Delete(customer2);
            cmManager.Listed(customers);

        }
    }
}
