using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class BrandsController:ControllerBase
    {
        IBrandServices _brandService;

        public BrandsController(IBrandServices brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var result = _brandService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
