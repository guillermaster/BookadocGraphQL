using GraphQL;
using GraphQL.Types;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bookadoc.Api.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Bookadoc.Api.Controllers
{
    [Route("api/[controller]")]
    public class GraphQLController : Controller
    {
        private readonly ILogger _logger;
        private IDocumentExecuter _documentExecuter { get; set; }
        private ISchema _schema { get; set; }
        
        public GraphQLController(IDocumentExecuter documentExecuter, ISchema schema, ILogger<GraphQLController> logger)
        {
            _documentExecuter = documentExecuter;
            _schema = schema;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            _logger.LogInformation("Got request for GraphiQL. Sending GUI back");
            return View();
        }
        
        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]GraphQLQuery query)
        {
            var executionOptions = new ExecutionOptions { Schema = _schema, Query = query.Query };
            var result = await new DocumentExecuter().ExecuteAsync(executionOptions).ConfigureAwait(false);

            if(result.Errors?.Count > 0)
            {
                _logger.LogError("GraphQL errors: {0}", result.Errors);
                return BadRequest();
            }

            _logger.LogDebug("GraphQL execution result: {result}", JsonConvert.SerializeObject(result.Data));
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
