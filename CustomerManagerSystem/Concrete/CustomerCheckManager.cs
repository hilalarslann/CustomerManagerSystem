using CustomerManagerSystem.Abstract;
using CustomerManagerSystem.Entities;

namespace CustomerManagerSystem.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService, ICustomerCheckBuy
    {
        public bool CheckBuy(Product product)
        {
            if (product.Name == "Coffee")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
