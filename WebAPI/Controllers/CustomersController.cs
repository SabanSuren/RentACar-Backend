using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {


            var result = _customerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("Add")]

        public IActionResult Add([FromBody] Customer customer)
        {
            var result = _customerService.AddCustomer(customer);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpGet("GetById")]

        public IActionResult GetById(int id)
        {
            var result = _customerService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetAllByUserId")]

        public IActionResult GetAllByUserId(int id) { 
            var result =_customerService.GetAllByUserId(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        
        
        }

        [HttpPost("Update")]
        public IActionResult Update(Customer customer)
        {

            return Ok(_customerService.UpdateCustomer( customer));
        }


        [HttpPost("Delete")]

        public IActionResult Delete(Customer customer)
        {

            return Ok(_customerService.DeleteCustomer(customer));
        }
    }
}
