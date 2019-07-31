using DemarestEscolaBackend.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemarestEscolaBackend.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IStudentClasseService _studentClasseService;

        public StudentController(IStudentService studentService, IStudentClasseService studentClasseService)
        {
            _studentService = studentService;
            _studentClasseService = studentClasseService;
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return Ok(_studentService.GetAll());
        }

        [HttpGet("classes/{id:int}")]
        public IActionResult GetAll([FromRoute] int id)
        {
            return Ok(_studentClasseService.GetByStudent(id));
        }
    }
}