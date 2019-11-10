namespace POC.Delivery.Api.ServiceClient
{
    using System.Threading.Tasks;
    using POC.Delivery.Api.Models;
    using Flurl.Http;

    public class BookHttpServiceClient : IServiceClient
    {
        const string apiEndPoint = "https://www.googleapis.com/books/v1/volumes?q=%7bsearch";

        public async Task<RootObject> GetBooks()
        {
            try
            {

                var response = await apiEndPoint
                                            .GetJsonAsync<RootObject>().ConfigureAwait(false);
                return response;
            }
            catch (FlurlHttpException)
            {

                throw;
            }

        }
    }
}
