using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _2Types.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AdminBaseController : ControllerBase
    {
    }
}