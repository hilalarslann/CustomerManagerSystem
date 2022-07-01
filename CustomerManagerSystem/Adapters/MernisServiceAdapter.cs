using CustomerManagerSystem.Abstract;
using CustomerManagerSystem.Entities;
using MernisServiceReference;
using System;

namespace CustomerManagerSystem.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client =
            new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId),
                customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
            var result = response.Result.Body.TCKimlikNoDogrulaResult;
            return result;
        }
    }
}
