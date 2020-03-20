using CoreCodeCamp.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoreCodeCamp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CampsController : ControllerBase
    {
        public object Get()
        {
            return new { Moniker = "ALT2018", Name = "Atlanta Code Camp" };
        }
    }
}
