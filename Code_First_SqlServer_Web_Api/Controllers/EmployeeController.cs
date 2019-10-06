using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Code_First_SqlServer_Web_Api.Models;
using Code_First_SqlServer_Web_Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Code_First_SqlServer_Web_Api.Controllers
{
    //[Route("api/[controller]")]
    [Route("/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataRepository<Employee> _dataRepository;
        public EmployeeController(IDataRepository<Employee> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        //GET: All data
        [HttpGet]
        [ActionName("GetAllEmployee")]
        public IActionResult Get()
        {
            IEnumerable<Employee> employees = _dataRepository.GetAll();
            return Ok(employees);
        }
        //POST: Insert Data
        [HttpPost]
        [ActionName("InsertEmployee")]
        public IActionResult Post([FromBody] Employee employee)
        {
            if(employee == null)
            {
                return BadRequest("Employee is null.");
            }
            _dataRepository.Add(employee);
            return CreatedAtRoute("Get", new { Id = employee.EmployeeId }, employee);
        }

        // GET: api by Id
        //[HttpGet("{id}",Name ="Get")]
        [HttpGet]
        [ActionName("GetEmployeeById")]
        public IActionResult Get(long id)
        {
            Employee employee = _dataRepository.Get(id);
            if(employee == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }
            return Ok(employee);
        }
        //PUT: api update
        //[HttpPut("id")]
        [HttpPut]
        [ActionName("UpdateEmployee")]
        public IActionResult Put(long id, [FromBody] Employee employee)
        {
            if(employee == null)
            {
                return BadRequest("Ëmployee is null.");
            }
            Employee employeeToUpdate = _dataRepository.Get(id);
            if(employeeToUpdate == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }
            _dataRepository.Update(employeeToUpdate, employee);
            return NoContent();
        }
        //DELETE: api remove data
        //[HttpDelete("{id}")]
        [HttpDelete]
        [ActionName("DeletetEmployee")]
        public IActionResult Delete(long id)
        {
            Employee employee = _dataRepository.Get(id);
            if(employee == null)
            {

                return NotFound("The Employee record couldn't be found.");
            }
            _dataRepository.Delete(employee);
            return NoContent();
        }
    }
}