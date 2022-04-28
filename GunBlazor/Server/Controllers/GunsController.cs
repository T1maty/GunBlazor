using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GunBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GunsController : ControllerBase
    {
        public static List<GunsController> guns = new List<GunsController>
        {
            new GunsController{Id = 1, Name = "JAVELIN",Price = "246000", Tip = "ANTITANK" },
            new GunsController{Id = 1, Name = "M1ABRAMS",Price = "8.6million", Tip = "TANK" },
            new GunsController{Id = 1, Name = "BRADLEY",Price =  "4million", Tip = "GUNNERY CAR" },
            new GunsController{Id = 1, Name = "ATACMS",Price = "2.3million", Tip = "STRATEGIC MISSILE" },
            new GunsController{Id = 1, Name = "M1097 Avenger",Price = "2million", Tip = "AIR DEFENSE" },
            

        };
        [HttpGet]
        public async Task<ActionResult<List<GunsController>>> GetGuns()
        {
            return Ok(guns);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<GunsController>>> GetSingleGuns(int id)
        {

            var gun = guns.FirstOrDefault(h => h.Id == id);
            if (gun == null)
            {
                return NotFound("Sorry, no millitary here.");
            }
            return Ok(guns);
        }

        public int Id { get; private set; }
        public object Name { get; private set; }
        public string Price { get; private set; }
        public string Tip { get; private set; }
    }
}
