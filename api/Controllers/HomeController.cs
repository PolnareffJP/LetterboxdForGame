using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : Controller
{
    [HttpGet("TestBackEnd")]
    public IActionResult TestBackEnd()
    {
        try
        {
            return Ok("Je fonctionne");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}