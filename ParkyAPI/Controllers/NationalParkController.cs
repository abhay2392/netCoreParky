using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkyAPI.Repository.IRepository;


namespace ParkyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalParkController : ControllerBase
    {
        private INationalParkRepository _npRepository;

        public NationalParkController(INationalParkRepository parkRepository)
        {
            _npRepository = parkRepository;
        }

        public IActionResult GetAllParks()
        {
            var praks = _npRepository.etAll().ToList() ;
            return Ok(praks);
        }
    }
}