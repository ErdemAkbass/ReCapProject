using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class brandsController : ControllerBase
    {
        IBrandService _brandService;

        public brandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpGet]
        [Route("GetBrands")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
           
           
        }
        [HttpPost]
        public IActionResult Post(Brand brand)
        {
            var result = _brandService.Add(brand);
            return Ok(result);
        }
    }
}
