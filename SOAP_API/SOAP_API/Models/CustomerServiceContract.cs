using System.ServiceModel;

namespace SOAP_API.Models
{
    public class CustomerServiceContract
    {
        [ServiceContract]
        public interface ICustomerService
        {
            [OperationContract]
            CustomerDataContract GetCustomers();
        }
    }
}
