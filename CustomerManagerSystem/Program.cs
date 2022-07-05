using CustomerManagerSystem.Abstract;
using CustomerManagerSystem.Adapters;
using CustomerManagerSystem.Concrete;
using CustomerManagerSystem.Entities;
using System;

namespace CustomerManagerSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "Hilal";

            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter(), new CustomerCheckManager());
            customerManager.Save(new Customer { FirstName = "Hilal", LastName = "Arslan", DateOfBirth = new DateTime(1997, 06, 29), NationalityId = "85486462200" });

            customerManager.Buy(customer1, new Product() { Name = "Coffee"});

            Console.ReadLine();
        }
    }
}
