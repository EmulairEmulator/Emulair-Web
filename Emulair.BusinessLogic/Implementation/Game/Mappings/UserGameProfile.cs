using AutoMapper;
using Emulair.BusinessLogic.Implementation.Game.Models;
using EmulairWEB.Models;

namespace Emulair.BusinessLogic.Implementation.Game.Mappings
{
    public class UserGameProfile : Profile
    {
        public UserGameProfile()
        {
            CreateMap<UserGame, GameListItem>()
                .ForMember(dest => dest.GameId, opt => opt.MapFrom(src => src.GameId))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Game.Title))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Game.Description))
                .ForMember(dest => dest.TotalHoursPlayed, opt => opt.MapFrom(src => src.TotalHoursPlayed))
                .ForMember(dest => dest.LastPlayed, opt => opt.MapFrom(src => src.LastPlayed));
        }
    }
}
