using Microsoft.AspNetCore.Mvc;
namespace CommandsService.Controllers
{

    [Route("/api/c/platforms")]
    [ApiController]
    public class PlatformsController: ControllerBase

    {   
        private readonly ICommandRepo _repository;
        private readonly IMapper _mapper;

        public PlatformsController(ICommandRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Test inbound connection to commands");
            return Ok("Inbound test of from Platforms Controler");
        }
    }
}