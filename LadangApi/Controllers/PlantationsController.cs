using System.Collections.Generic;
using LadangApi.Interface;
using LadangApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LadangApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantationsController : ControllerBase
    {
        private IPlantationDbContext _plantationDbContext;

        public PlantationsController(IPlantationDbContext plantationDbContext)
        {
            _plantationDbContext = plantationDbContext;
        }


        // GET: api/<PlantationsController>
        [HttpGet]
        public IEnumerable<Plantation> Get()
        {
            return _plantationDbContext.Plantations;
        }

        // GET api/<PlantationsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlantationsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PlantationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlantationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}