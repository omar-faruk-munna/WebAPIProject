using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIProject.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IEmployeeRepo _employeeRepo;
        public HomeController(IEmployeeRepo employeeRepo)
        {
            this._employeeRepo = employeeRepo;
        }

        // GET: api/Home
        [HttpGet]
        [Route("get-all")]
        public IActionResult GetAll()
        {
            var ret = _employeeRepo.GetAllEmployee();
            return new OkObjectResult(ret);
        }

        // GET: api/Home/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Home
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Home/5
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
