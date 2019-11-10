namespace POC.Delivery.Api.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using POC.Delivery.Api.Models;
    using POC.Delivery.Api.ServiceClient;

    public class BookService : IBookService
    {
        
        private readonly IServiceClient _serviceClient;

        public BookService(IServiceClient serviceClient)
        {
            
            _serviceClient = serviceClient;
        }

        public async Task<List<Book>> GetShoppingBooks()
        {
            var bookList = new List<Book>();

            var bookObject = await  _serviceClient.GetBooks();

            foreach (var item in bookObject.items)
            {
                var book = new Book()
                {
                    Author = string.Join(", ", item.volumeInfo.authors.ToArray()),
                    Title = item.volumeInfo.title,
                    PublishedDate = item.volumeInfo.publishedDate,
                    Description = item.volumeInfo.description
                };
                bookList.Add(book);
            }
            return bookList;
        }
    }
}
