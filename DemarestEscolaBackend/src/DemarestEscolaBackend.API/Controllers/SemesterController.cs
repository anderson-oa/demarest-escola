using System;
using System.Linq;
using DemarestEscolaBackend.Domain.Entities.Enum;
using Microsoft.AspNetCore.Mvc;

namespace DemarestEscolaBackend.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SemesterController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult GetAll()
        {
            return Ok(Enum.GetValues(typeof(Semester))
                          .Cast<Semester>()
                          .Select(item => new
                          {
                              value = (int)item,
                              label = item
                          }));
        }
    }
}