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
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { FirstName = "Hilal", LastName = "Arslan", DateOfBirth = new DateTime(1997, 06, 29), NationalityId = "85486462200" });



            Console.ReadLine();
        }
    }
}
