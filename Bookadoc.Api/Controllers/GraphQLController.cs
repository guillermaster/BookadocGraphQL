﻿using GraphQL;
using GraphQL.Types;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bookadoc.Api.Models;

namespace Bookadoc.Api.Controllers
{
    [Route("api/[controller]")]
    public class GraphQLController : Controller
    {
        private UserQuery _userQuery { get; set; }

        public GraphQLController(UserQuery userQuery)
        {
            _userQuery = userQuery;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        // GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]GraphQLQuery query)
        {
            var schema = new Schema { Query = _userQuery };

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
