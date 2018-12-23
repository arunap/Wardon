using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wardon.Contracts;
using Wardon.Domain.ViewModels;

namespace Wardon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: api/Books
        [HttpGet]
        [Produces(typeof(List<BookViewModel>))]
        public async Task<IActionResult> GetAllBooks(CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await _bookService.GetBooksAsync(cancellationToken);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        // GET: api/Books/5
        [HttpGet("{id}", Name = "Get")]
        [Produces(typeof(BookViewModel))]
        public async Task<IActionResult> Get(int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await _bookService.GetBookAsync(id, cancellationToken);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        // POST: api/Books
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BookViewModel value)
        {
            var result = await _bookService.InsertBookAsync(value);
            return Ok(result);
        }

        // PUT: api/Books/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] BookViewModel value)
        {
            var result = await _bookService.UpdateBookAsync(value);
            return Ok(result);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _bookService.DeleteBookAsync(id);
            return Ok(result);
        }
    }
}
