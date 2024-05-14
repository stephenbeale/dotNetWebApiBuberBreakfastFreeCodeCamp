using BuberBreakfast.Contracts.Breakfast;

using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers
{
    public class BreakfastsController : ControllerBase
    {
        [HttpPost("/breakfasts")]
        public IActionResult CreateBreakfast(CreateBreakfastRequest request)
        {
            return Ok(request);
        }

        [HttpGet("/breakfasts{id:guid}")]
        public IActionResult GetBreakfast(CreateBreakfastRequest request)
        {
            return Ok(request);
        }

        [HttpPut("/breakfasts{id:guid}")]
        public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
        {
            return Ok(request);
        }

        [HttpDelete("/breakfasts{id:guid}")]
        public IActionResult DeleteBreakfast(CreateBreakfastRequest request)
        {
            return Ok(request);
        }
    }
}
