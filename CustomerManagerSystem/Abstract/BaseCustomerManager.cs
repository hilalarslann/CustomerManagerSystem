using CustomerManagerSystem.Entities;
using System;

namespace CustomerManagerSystem.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db " + customer.FirstName);
        }

        public abstract void Buy(Customer customer, Product product);

        public virtual void GiveStar(Customer customer)
        {
            Console.WriteLine("Gived star " + customer.FirstName);
        }
    }
}
