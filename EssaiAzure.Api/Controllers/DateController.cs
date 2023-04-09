using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EssaiAzure.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateController : ControllerBase
    {

        [HttpGet]
        public string Today()
        {
            return DateTime.Now.ToLongDateString();
        }

    }
}
