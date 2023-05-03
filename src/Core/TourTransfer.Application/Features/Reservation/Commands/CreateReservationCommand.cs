using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTransfer.Application.Interfaces.Repository;
using TourTransfer.Application.Interfaces.UnitOfWork;
using TourTransfer.Domain.Entities;
using TourTransfer.Infrastructure.Dtos;

namespace TourTransfer.Application.Features.Reservation.Commands
{
    public class CreateReservationCommand : IRequest<ActionResponse<bool>>
    {
        public Guid Id { get; set; }
    }

    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, ActionResponse<bool>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IRepository<Domain.Entities.Reservation> _reservationRepo;

        public CreateReservationCommandHandler(IUnitOfWork uow, IRepository<Domain.Entities.Reservation> reservationRepo)
        {
            _uow = uow;
            _reservationRepo = reservationRepo;
        }

        public async Task<ActionResponse<bool>> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
