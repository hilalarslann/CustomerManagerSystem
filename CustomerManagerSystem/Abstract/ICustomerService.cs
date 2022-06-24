using CustomerManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagerSystem.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
