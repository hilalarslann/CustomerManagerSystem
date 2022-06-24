using CustomerManagerSystem.Abstract;
using CustomerManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagerSystem.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        public override void Save(Customer customer)
        {
            base.Save(customer);
        }
    }
}
