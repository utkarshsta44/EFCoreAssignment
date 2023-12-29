using EFCoreApplication.Data;
using EFCoreApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly LibraryDbContext _context;
         public BookController(LibraryDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult CreateBook([FromBody] Book book) 
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return Ok(book);
        }

        [HttpGet]
        public IActionResult GetBook()
        {
             var book = _context.Books.ToList();
            return Ok(book);

        }
    }
}
