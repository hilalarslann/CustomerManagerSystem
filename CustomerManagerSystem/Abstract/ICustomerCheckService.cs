using CustomerManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagerSystem.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
