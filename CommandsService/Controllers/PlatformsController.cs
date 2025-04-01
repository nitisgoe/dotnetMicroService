using Microsoft.AspNetCore.Mvc;
namespace CommandsService.Controllers
{

    [Route("/api/c/platforms")]
    [ApiController]
    public class PlatformsController: ControllerBase

    {

        public PlatformsController(){}

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Test inbound connection to commands");
            return Ok("Inbound test of from Platforms Controler");
        }
    }
}