using CustomerManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagerSystem.Abstract
{
    public interface ICustomerCheckBuy
    {
        bool CheckBuy(Product product);
    }
}
