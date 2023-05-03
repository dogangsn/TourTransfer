using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TourTransfer.WebAPI.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarsController(IMediator mediator)   
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        //[HttpPost(Name = "CreateCars")]
        //public async Task<IActionResult> CreateCars(CreateCarsCommand createCarsCommand)
        //{
        //    return Ok(await _mediator.Send(createCarsCommand));
        //}

    }
}
