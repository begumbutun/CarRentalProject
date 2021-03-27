using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class RentsController : ControllerBase
    {
        IRentsService _rentsService;

        public RentsController(IRentsService rentsService)
        {
            _rentsService = rentsService;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var result = _rentsService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
