using AutoMapper;
using Emulair.BusinessLogic.Implementation.News.Models;
using Emulair.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulair.BusinessLogic.Implementation.News.Mappings
{
    public class NewsMapper : Profile
    {
        public NewsMapper()
        {
            CreateMap<News1, NewsModel>()
               .ForMember(a => a.NewsId, a => a.MapFrom(s => s.NewsId))
               .ForMember(a => a.AuthorId, a => a.MapFrom(s => s.AuthorId))
               .ForMember(a => a.Description, a => a.MapFrom(s => s.Description))
               .ForMember(a => a.PostDate, a => a.MapFrom(s => s.PostDate))
               .ForMember(a => a.Title, a => a.MapFrom(s => s.Title));

            CreateMap<News1, EditNewsModel>()
               .ForMember(a => a.Description, a => a.MapFrom(s => s.Description))
               .ForMember(a => a.Title, a => a.MapFrom(s => s.Title));

            CreateMap<EditNewsModel, NewsModel>()
               .ForMember(a => a.AuthorId, a => a.Ignore())
               .ForMember(a => a.Description, a => a.MapFrom(s => s.Description))
               .ForMember(a => a.PostDate, a => a.Ignore())
               .ForMember(a => a.Title, a => a.MapFrom(s => s.Title))
               .ForMember(a => a.Replies, a => a.Ignore())
               .ForMember(a => a.NewComment, a => a.Ignore())
               .ForMember(a => a.Comments, a => a.Ignore())
               .ForMember(a => a.Images, a => a.Ignore());


            CreateMap<NewsModel, News1>()
               .ForMember(a => a.NewsId, a => a.MapFrom(s => s.NewsId))
               .ForMember(a => a.AuthorId, a => a.MapFrom(s => s.AuthorId))
               .ForMember(a => a.Description, a => a.MapFrom(s => s.Description))
               .ForMember(a => a.PostDate, a => a.MapFrom(s => s.PostDate))
               .ForMember(a => a.Title, a => a.MapFrom(s => s.Title));
        }
    }
}
