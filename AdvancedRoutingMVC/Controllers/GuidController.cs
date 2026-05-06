using Microsoft.AspNetCore.Mvc;

namespace AdvancedRoutingMVC.Controllers
{
    public class GuidController : Controller
    {
        [Route("GuidTest/{id:guidcheck}")]
        public IActionResult Index(Guid id)
        {
            return Content($"Valid GUID: {id}");
        }
    }
}