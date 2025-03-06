using GitHubExample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ExceptionServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GitHubExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitController : ControllerBase
    {
        // GET: api/<GitController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<GitController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GitController>
        [HttpPost]
        public int Post([FromBody] GitHub gitHub)
        {
            int sum = gitHub.FirstValue + gitHub.SecondValue;

            return sum;
        }

        // PUT api/<GitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
