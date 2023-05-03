using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourTransfer.Application.Features.Reservation.Commands;
using TourTransfer.Application.Features.Reservation.Queries;

namespace TourTransfer.WebAPI.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReservationController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        #region AdminClientReservation

        [HttpPost(Name = "CreateReservation")]
        public async Task<IActionResult> CreateReservation(CreateReservationCommand model) => Ok(await _mediator.Send(model));

        [HttpGet(Name ="GetReservation")]
        public async Task<IActionResult> GetReservation(GetReservationQuery model) => Ok(await _mediator.Send(model));

        #endregion


        #region ClientReservation

        #endregion


    }
}
