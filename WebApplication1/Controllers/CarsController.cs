﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
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
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet]
        [Route("getCarsCont")]
        public IActionResult Get()
        {

            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

            //[HttpPost]
            //public IActionResult Post(Car car)
            //{
            //    var result = _carService.add(car);
            //    if (result.Success)
            //    {
            //        return Ok(result);
            //    }
            //    return BadRequest(result);
            }
        }
    

