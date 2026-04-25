using Application.Interfaces;
using Application.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController(IEmployeeService employeeService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await employeeService.GetAllEmployeesAsync();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await employeeService.GetEmployeeByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);  
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateEmployeeRequest request)
        {
            var id = await employeeService.CreateEmployeeAsync(request);
            return CreatedAtAction(nameof(GetById), new { id }, id);
        }
    }
}
