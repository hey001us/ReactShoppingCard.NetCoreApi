using POC.Delivery.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Delivery.Api.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetShoppingBooks();
    }
}
