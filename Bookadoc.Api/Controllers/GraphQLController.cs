using GraphQL;
using System.Collections.Generic;
using GraphQL.Types;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bookadoc.Api.Models;
using Bookadoc.Data.InMemory;

namespace Bookadoc.Api.Controllers
{
    [Route("api/[controller]")]
    public class GraphQLController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]GraphQLQuery query)
        {
            var schema = new Schema { Query = new UserQuery(new UserRepository()) };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;
            }).ConfigureAwait(false);

            if(result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
