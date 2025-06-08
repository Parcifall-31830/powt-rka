using Microsoft.AspNetCore.Mvc;
using WebApplication4.Data;
using WebApplication4.Models;
using WebApplication4.Services;

namespace WebApplication4.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController(IDbService service):ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetStudents()
    {
        return Ok(await service.GetStudents());
    }
    
}