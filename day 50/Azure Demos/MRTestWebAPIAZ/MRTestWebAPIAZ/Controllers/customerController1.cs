using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MRTestWebAPIAZ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class customerController1 : ControllerBase
    {
        // GET: api/<customerController1>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "christy", "adhithya" };
        }

        // GET api/<customerController1>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<customerController1>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<customerController1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<customerController1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
