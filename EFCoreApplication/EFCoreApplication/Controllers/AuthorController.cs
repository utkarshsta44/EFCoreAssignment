using EFCoreApplication.Data;
using EFCoreApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly LibraryDbContext _context;
        public AuthorController(LibraryDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateAuthor([FromBody] Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
            return Ok(author);
        }

        [HttpGet]
        public IActionResult GetAuthor()
        { 
            var author = _context.Authors.ToList();
            return Ok(author);
        }

    }
}
