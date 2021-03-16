using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_1._5.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {
        [HttpGet("student/{studentName}")]
        [HttpGet("student/{studentName}/{*path}")]
        public IActionResult Index(string studentName, string path)
        {
            return Ok(studentName);
        }
    }
}
