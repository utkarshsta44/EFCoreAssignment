using EFCoreApplication.Data;
using EFCoreApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly LibraryDbContext _libraryDbContext;
         public PersonController(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }

        [HttpPost]
         public IActionResult CreatePerson([FromBody] Person person) 
        {
            _libraryDbContext.Persons.Add(person);
            _libraryDbContext.SaveChanges();
            return Ok(person);
        }
        [HttpGet]
         public IActionResult GetPerson() 
        { 
             var person=_libraryDbContext.Persons.ToList();
            return Ok(person);  
        }
    }
}
