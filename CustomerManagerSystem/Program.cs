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
            customerManager.Save(new Customer { FirstName = "Hilal", LastName = "Arslan", DateYear = 1997, NationalityId = 17856987458 });

            customerManager.Buy(customer1, new Product() { Name = "Coffee" });

            Console.ReadLine();
        }
    }
}
