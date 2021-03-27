using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class ColorsController:ControllerBase
    {
        IColorServices _colorService;

        public ColorsController(IColorServices colorService)
        {
            _colorService = colorService;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var result = _colorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
