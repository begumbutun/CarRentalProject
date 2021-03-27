using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.CarImages;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImagesServices _carImagesServices;

        public CarImagesController(ICarImagesServices carImagesServices)
        {
            _carImagesServices = carImagesServices;
        }

        [HttpPost("Add")]
        public IActionResult Add( [FromForm] CarImages carImages, [FromForm] IFormFile file)
        {
            var result = _carImagesServices.Add(carImages , file);
            if (result.Success)
            {

                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromForm] CarImages carImages)
        {

            

            var result = _carImagesServices.Delete(carImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update([FromForm] CarImages carImages , [FromForm] IFormFile formFile)
        {
            
            var result = _carImagesServices.Update( carImages, formFile);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImagesServices.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

     


    }
}