using CustomerManagerSystem.Abstract;
using CustomerManagerSystem.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagerSystem.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient mernisClient = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return Convert.ToBoolean(mernisClient.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName,customer.DateOfBirth.Year));
        }
    }
}
