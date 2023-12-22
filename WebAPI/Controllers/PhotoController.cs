using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        IPhotoService _photoservice;

        public PhotoController(IPhotoService photoservice)
        {
            _photoservice = photoservice;
        }


        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {


            var result = _photoservice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }
        [HttpPost("Add")]
        public IActionResult Add([FromForm] IFormFile file, [FromForm] Photo photo)
        {
            var result=_photoservice.Add(file,photo);

            if(result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

      

       
        [HttpGet("GetById")]

        public IActionResult GetById(int id)
        {
            var result=_photoservice.GetAllByCarId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("UpdatePhoto")]

        public IActionResult UpdatePhoto([FromForm] IFormFile file, [FromForm] Photo photo)
        {
            var result=_photoservice.Update(file,photo);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("DeletePhoto")]

        public IActionResult DeletePhoto(Photo photo)
        {
            var result=_photoservice.Delete(photo);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    } 
}
