namespace POC.Delivery.Api.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using POC.Delivery.Api.Models;
    using POC.Delivery.Api.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Book>> Get()
        {
            var result = await _bookService.GetShoppingBooks().ConfigureAwait(false);
            return result;
        }
    }
}
