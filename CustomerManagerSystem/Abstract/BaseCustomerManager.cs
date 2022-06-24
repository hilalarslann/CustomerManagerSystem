using CustomerManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagerSystem.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db" + customer.FirstName);
        }
    }
}
