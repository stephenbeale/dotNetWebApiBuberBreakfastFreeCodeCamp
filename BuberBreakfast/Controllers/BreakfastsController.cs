using BuberBreakfast.Contracts.Breakfast;

using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers
{
    public class BreakfastsController : ControllerBase
    {
        [HttpPost("/breakfasts")]
        public IActionResult CreateBreakfast(CreateBreakfastRequest request)
        {
            return Ok();
        }
    }
}
