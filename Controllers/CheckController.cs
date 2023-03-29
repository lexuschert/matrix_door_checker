using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers;

public class CheckController : AbstractBaseController
{
    [HttpGet, HttpPost]
    public IActionResult Index()
    {

        var request = Request;
        
        return Ok();
    }
}