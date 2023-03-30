using Business.Abstract;
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
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService cutomerService)
        {
            _customerService = cutomerService;
        }
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            return Ok(result);
        }
    }
}
