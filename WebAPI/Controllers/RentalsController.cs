using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalservice;

        public RentalsController(IRentalService rentalservice)
        {
            _rentalservice = rentalservice;
        }


        [HttpGet("GetAll")]

        public IActionResult Getall() { 
        
            var result=_rentalservice.GetAll();

            if (result.Success) { 
            
                return Ok(result);
            
            }

            return BadRequest(result);
        
        }

        [HttpGet("GetById")]

        public IActionResult GetById(int id) { 
            var result=_rentalservice.getById(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        
        
        }

        [HttpGet("GetRentalDetail")]

        public IActionResult GetRentalDetail() {

            var result=_rentalservice.GetRentalDetails();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        
        
        
        
        }

        [HttpPost("Add")]

        public IActionResult Add(Rental rental) {

            var result=_rentalservice.AddRental(rental);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        
        
        
        }

        [HttpPost("Delete")]

        public IActionResult Delete(Rental rental) { 

            var result=_rentalservice.DeleteRental(rental);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        
        
        
        }

        [HttpGet("checkrentalcarid")]
        public IActionResult CheckRentalCarId(int carId)
        {
            var result = _rentalservice.CheckRentalCarId(carId);

            return Ok(result);


        }


        [HttpPost("Update")]

        public IActionResult Update(Rental rental)
        {
            var result=_rentalservice.UpdateRental(rental);

            if (result.Success)
            {
                return Ok(result);
            }
             return BadRequest(result);

        }
    }
}
