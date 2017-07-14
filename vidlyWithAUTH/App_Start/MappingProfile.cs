using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidlyWithAUTH.Dtos;
using vidlyWithAUTH.Models;

namespace vidlyWithAUTH.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            // Domain to dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            // Dto to domain
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<MovieDto,Movie>();
        }
    }
}