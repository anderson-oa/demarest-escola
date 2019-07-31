using System;
using DemarestEscolaBackend.Domain.Entities;
using DemarestEscolaBackend.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemarestEscolaBackend.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;

        public ExamController(IExamService examService)
        {
            _examService = examService;
        }

        [HttpPost("")]
        public IActionResult Create([FromBody] Exam exam)
        {
            try
            {
                _examService.Create(exam);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return Ok(_examService.GetAll());
        }
    }
}