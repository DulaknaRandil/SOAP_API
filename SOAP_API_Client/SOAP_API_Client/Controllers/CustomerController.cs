using CustomerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SOAP_API_Client.Controllers
{
    [ApiController]
    [Route("CustomerController")]
    public class CustomerController : Controller
    {
         [HttpGet]
          public async Task <CustomerDataContract> GetCustomersAysnc()
          {
              ICustomerService customerService =
                  new CustomerServiceClient(CustomerServiceClient.EndpointConfiguration.BasicHttpBinding_ICustomerService);
              return await customerService.GetCustomersAsync();
          }
    }
}
