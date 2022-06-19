using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using API.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : ControllerBase
    {
        // GET: api/<OperacionesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<OperacionesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OperacionesController>
        [HttpPost("Suma")]
        public ActionResult Suma([FromBody] JsonElement body)
        {
            Operaciones sOperaciones = new Operaciones();
            return Ok(new { result = sOperaciones.Suma(body.GetProperty("n1").GetInt32(), body.GetProperty("n2").GetInt32(), body.GetProperty("n3").GetInt32()) });
        }

        [HttpGet("Multiplicacion")]
        public ActionResult Multiplicacion()
        {
            int n1 = int.Parse(Request.Headers["n1"]);
            int n2 = int.Parse(Request.Headers["n2"]);
            int n3 = int.Parse(Request.Headers["n3"]);
            Operaciones sOperaciones = new Operaciones();
            return Ok(new { result = sOperaciones.Multiplicacion(n1,n2,n3) });
        }

        // PUT api/<OperacionesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OperacionesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
