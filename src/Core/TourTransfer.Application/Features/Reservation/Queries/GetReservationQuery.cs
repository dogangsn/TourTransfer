using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTransfer.Application.Interfaces.Repository;
using TourTransfer.Application.Interfaces.UnitOfWork;
using TourTransfer.Application.Models;
using TourTransfer.Infrastructure.Dtos;

namespace TourTransfer.Application.Features.Reservation.Queries
{
    public class GetReservationQuery : IRequest<ActionResponse<ClientReservationDto>>
    {
    }

    public class GetReservationQueryHandler : IRequestHandler<GetReservationQuery, ActionResponse<ClientReservationDto>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IRepository<Domain.Entities.Reservation> _reservationRepo;

        public GetReservationQueryHandler(IUnitOfWork uow, IRepository<Domain.Entities.Reservation> reservationRepo)
        {
            _uow = uow;
            _reservationRepo = reservationRepo;
        }

        public async Task<ActionResponse<ClientReservationDto>> Handle(GetReservationQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
