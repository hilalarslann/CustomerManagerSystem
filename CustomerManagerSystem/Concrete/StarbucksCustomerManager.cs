using CustomerManagerSystem.Abstract;
using CustomerManagerSystem.Entities;
using System;

namespace CustomerManagerSystem.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;
        ICustomerCheckBuy _customerCheckBuy;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService, ICustomerCheckBuy customerCheckBuy)
        {
            _customerCheckService = customerCheckService;
            _customerCheckBuy = customerCheckBuy;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Not a valid person");
            }
        }

        public override void Buy(Customer customer, Product product)
        {
            if (_customerCheckBuy.CheckBuy(product))
            {
                GiveStar(customer);
            }
        }
    }
}
