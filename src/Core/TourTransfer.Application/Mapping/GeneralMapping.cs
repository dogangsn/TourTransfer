using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTransfer.Application.Models;
using TourTransfer.Domain.Entities;

namespace TourTransfer.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Reservation, AdminClientReservationDto>().ReverseMap();
        }
    }
}
