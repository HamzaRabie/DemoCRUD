using DemoCRUD.Data;
using DemoCRUD.Model;
using DemoCRUD.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IDriverRepository driver;

        public DriverController( IDriverRepository driver )
        {
            this.driver = driver;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok( driver.GetAllDrivers() );
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok( driver.GetDriverById(id) );
        }

        [HttpPost("Add")]
        public IActionResult AddDriver(Driver newdriver)
        {
            driver.AddDriver(newdriver);
            return Ok();

        }

        [HttpPost("Delete")]
        public IActionResult DeleteDriver(int id)
        {
            bool f = driver.DeleteDriver(id);
            if(f) return Ok();
            else return BadRequest();

        }

    }
}
