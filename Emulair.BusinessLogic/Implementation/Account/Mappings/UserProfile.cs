using AutoMapper;
using Emulair.Entities;
using EmulairWEB.Models;
using System;

namespace Emulair.BusinessLogic.Implementation.Account
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterModel, User>()
                .ForMember(a => a.UserId, a => a.MapFrom(s => Guid.NewGuid()))
                .ForMember(a => a.PasswordHash, a => a.MapFrom(s => s.Password));
        }
    }
}
