using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestingConnectionWithPostgre.Models;

namespace TestingConnectionWithPostgre.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly MyWebApiContext _context;

        public PersonController(MyWebApiContext context)
        {
            _context = context;
        }
        
        [HttpPost]
        public async Task<IActionResult> CreatePerson()
        {
            var person = new Person { Address = "hoho", City = "Dnipro", FirstName = "Vasyan", LastName = "Pupkin" };
            _context.Persons.Add(person);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var persons = _context.Persons.ToList();

            return Ok(persons);
        }
    }
}
