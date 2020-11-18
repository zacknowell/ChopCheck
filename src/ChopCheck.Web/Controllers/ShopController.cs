using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChopCheck.Web.Controllers
{
    // Unsure whether to use Dapper or EF, EF is heavy but dev friendly, Dapper is quick but requires more SQL 
    // Use https://developer.okta.com/blog/2018/04/26/build-crud-app-aspnetcore-angular for api guidance
    // https://dotnetcoretutorials.com/2019/08/05/dapper-in-net-core-part-2-dapper-query-basics/

    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        // GET: api/Shop
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Shop/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Shop
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Shop/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
