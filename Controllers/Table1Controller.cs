using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment2API.Models;

namespace Assignment2API.Controllers
{
    [Produces("application/json")]
    [Route("api/Table1")]
    public class Table1Controller : Controller
    {
        private Model1 db;

        public Table1Controller(Model1 db)
        {

            this.db = db;

        }

        // GET: api/Table1
        [HttpGet]
        public IEnumerable<Table1> Get()
        {
            return db.Table1.OrderBy(a => a.companyname).ToList();
        }

        // GET: api/Table1/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Table1
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Table1/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
