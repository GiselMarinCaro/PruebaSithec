using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Service;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanoController : ControllerBase
    {
        // GET: api/<HumanoController>
        [HttpGet]
        public IEnumerable<Humano> Get()
        {
            serviceHumano serviceHuman = new serviceHumano();
            return serviceHuman.generateList();
        }

        // GET api/<HumanoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HumanoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HumanoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HumanoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
