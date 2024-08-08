using SOAP_API.Models;
using System.ComponentModel.DataAnnotations;
using static SOAP_API.Models.CustomerServiceContract;


namespace SOAP_API.Services
{
    public class CustomerService : ICustomerService
    {
        public CustomerDataContract GetCustomers()
        {
            return new CustomerDataContract
            {
                Id = 1,
                FirstName = "John",
            LastName = "Doe",
            EmailAddress = "john.example.com",



            };
        }
    }
}
