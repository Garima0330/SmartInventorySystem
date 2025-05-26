using Microsoft.AspNetCore.Mvc;

namespace SmartInventory.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult SayHello()
        {
            return Ok("Welcome to SmartInventorySystem API!");
        }
    }
}
