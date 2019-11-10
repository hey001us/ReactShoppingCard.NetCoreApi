namespace POC.Delivery.Api.ServiceClient
{
    using POC.Delivery.Api.Models;
    using System.Threading.Tasks;

    public interface IServiceClient
    {
        Task<RootObject> GetBooks();
    }
}
