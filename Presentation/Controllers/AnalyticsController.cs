using Microsoft.AspNetCore.Mvc;

namespace AnalyticsService.Presentation.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class AnalyticsController : ControllerBase {
        [HttpGet("overview")]
        public IActionResult GetOverview() => Ok("Analytics Overview");
    }
}