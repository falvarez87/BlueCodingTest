using ApplicationCore;
using Infraestructure.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FishController : ControllerBase
    {
        ApplicationDbContext _db;

        public FishController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: api/<FishController>
        [HttpGet]
        public IEnumerable<Fish> Get()
        {
            return _db.Fish.ToList();
        }

        // GET api/<FishController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FishController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FishController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FishController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
