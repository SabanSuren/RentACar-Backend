using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            this._carService = carService;
        }

        [HttpGet("GetAll")]


        public IActionResult GetAll()
        {
            var result=_carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getcarbycolorid")]
        public IActionResult GetCarByColorId(int id)
        {
            var result = _carService.GetCarsByColorId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("GetByBrandId")]

        public IActionResult GetByBrandId(int id) {
        
            var result=_carService.GetAllByBrandId(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        
        }

        [HttpGet("GetCarDetails")]


        public IActionResult GetCarDetails() {

            var result=_carService.GetCarDetails();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        
        
        
        }

        [HttpPost("Add")]

        public IActionResult Add([FromBody] Car car)
        {
            var result=_carService.AddCar(car);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpDelete("Delete")]


        public IActionResult Delete( Car car)
        {

           return Ok(_carService.DeleteCar(car));
        }

        [HttpPut("Update")]

        public IActionResult Update( Car car)
        {

            return Ok(_carService.UpdateCar(car));
        }

        [HttpGet("GetByDailyPrice")]

        public IActionResult GetByDailyPrice(decimal min ,decimal max) { 

            var result=_carService.GetByDailyPrice(min,max);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
}
