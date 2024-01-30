using AutoMapper;
using CollectiHaven.BusinessLogic.Implementation.Account.Models;
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

            CreateMap<User, UserModel>()
                .ForMember(a => a.Id, a => a.MapFrom(s => s.UserId))
                .ForMember(a => a.RegistrationDay, a => a.MapFrom(s => s.RegistrationDate))
                .ForMember(a => a.Email, a => a.MapFrom(s => s.Email))
                .ForMember(a => a.Role, a => a.MapFrom(s => s.Role))
                .ForMember(a => a.FirstName, a => a.MapFrom(s => s.FirstName))
                .ForMember(a => a.LastName, a => a.MapFrom(s => s.LastName));
        }
    }
}
