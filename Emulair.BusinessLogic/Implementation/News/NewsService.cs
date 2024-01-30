using AutoMapper;
using Emulair.BusinessLogic.Base;
using Emulair.BusinessLogic.Implementation.News.Models;
using Emulair.BusinessLogic.Implementation.News.Validations;
using Emulair.Common.Exceptions;
using Emulair.Common.Extensions;
using Emulair.DataAccess;
using Emulair.Entities.Entities;
using EmulairWEB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulair.BusinessLogic.Implementation.News
{
    public class NewsService : BaseService
    {
        private readonly CreateNewsValidator CreateNewsValidator;
        private readonly EditNewsValidator EditNewsValidator;
        private readonly AddCommentValidator AddCommentValidator;
        public NewsService(ServiceDependencies serviceDependencies, IConfiguration configuration) : base(serviceDependencies)
        {

            this.CreateNewsValidator = new CreateNewsValidator(serviceDependencies.UnitOfWork);
            this.EditNewsValidator = new EditNewsValidator(serviceDependencies.UnitOfWork);
            this.AddCommentValidator = new AddCommentValidator();
        }
        public List<NewsModel> DisplayNews()
        {
            var newsList = new List<NewsModel>();
            var news = UnitOfWork.News.Get().Where(n => n.IsDeleted == false).ToList();
            var comments = UnitOfWork.Comments.Get().ToList();
            foreach (var n in news)
            {
                var newsImages = UnitOfWork.NewsImages
                    .Where(ne => ne.NewsId == n.NewsId)
                    .Include(ne => ne.Image)
                    .ToList();

                var imageIds = newsImages.Select(ne => ne.ImageId).ToList();

                var listImages = UnitOfWork.Images
                    .Where(image => imageIds.Contains(image.ImageId))
                    .Select(image => image.Content)
                    .ToList();

                var newsComments = new List<Comment>();
                foreach (var c in comments)
                {
                    newsComments.Add(c);
                }

                var newNews = Mapper.Map<News1, NewsModel>(n);
                newNews.Comments = newsComments;
                newNews.Images = listImages;
                newNews.Author = UnitOfWork.Users.Find(newNews.AuthorId).FirstName + " " + UnitOfWork.Users.Find(newNews.AuthorId).LastName;
                newsList.Add(newNews);
            }
            return newsList;
        }

        public List<NewsModel> GetLastestNews(int count)
        {
            var lastNews = new List<NewsModel>();
            lastNews = UnitOfWork.News.Get().Where(n => n.IsDeleted == false).OrderByDescending(n => n.PostDate).Select(n => Mapper.Map<News1, NewsModel>(n)).Take(count).ToList();
            return lastNews;
        }
        public void CreateNews(NewsModel newsModel, List<byte[]> imageBytesList)
        {

            newsModel.NewsId = Guid.NewGuid();
            CreateNewsValidator.Validate(newsModel).ThenThrow(newsModel);

            var news = new News1
            {
                NewsId = newsModel.NewsId,
                AuthorId = CurrentUser.Id,
                Description = newsModel.Description,
                PostDate = DateTime.Now,
                Title = newsModel.Title
            };

            UnitOfWork.News.Insert(news);
            foreach (var imageBytes in imageBytesList)
            {
                if (imageBytes.Length > 0)
                {
                    var image = new Image { ImageId = Guid.NewGuid(), Content = imageBytes };
                    UnitOfWork.Images.Insert(image);
                    var newsImage = new NewsImage { NewsImageId = Guid.NewGuid(), NewsId = news.NewsId, ImageId = image.ImageId };
                    UnitOfWork.NewsImages.Insert(newsImage);
                }
            }

            UnitOfWork.SaveChanges();

        }
        public NewsModel GetNewsById(Guid newsId)
        {
            if (newsId == null)
            {
                throw new NotFoundErrorException();
            }
            var news = UnitOfWork.News.Find(newsId);
            if (news == null)
            {
                throw new NotFoundErrorException();
            }
            var comments = UnitOfWork.Comments.Get().Where(c => c.NewsId == newsId).ToList();
            var newsModel = Mapper.Map<News1, NewsModel>(news);
            newsModel.Comments = comments;
            newsModel.Author = UnitOfWork.Users.Find(newsModel.AuthorId).FirstName + " " + UnitOfWork.Users.Find(newsModel.AuthorId).LastName;
            var existingImages = GetNewsImages(newsId);
            newsModel.Images = existingImages;
            return newsModel;
        }

        public News1 EditNews(NewsModel newsModel, List<byte[]> imageBytesList)
        {
            EditNewsValidator.Validate(newsModel).ThenThrow(newsModel);
            var news = UnitOfWork.News.Get()
                .FirstOrDefault(n => n.NewsId == newsModel.NewsId)
                ;
            if (news == null)
            {
                throw new NotFoundErrorException();
            }
            news.Title = newsModel.Title;
            news.Description = newsModel.Description;

            if (imageBytesList != null && imageBytesList.Any())
            {
                var existingImages = UnitOfWork.NewsImages.Where(pi => pi.NewsId == news.NewsId).ToList();

                foreach (var existingImage in existingImages)
                {
                    UnitOfWork.NewsImages.Delete(existingImage);
                }

                foreach (var imageBytes in imageBytesList)
                {
                    if (imageBytes.Length > 0)
                    {
                        var image = new Image { ImageId = Guid.NewGuid(), Content = imageBytes };
                        UnitOfWork.Images.Insert(image);
                        var newsImage = new NewsImage { NewsImageId = Guid.NewGuid(), NewsId = news.NewsId, ImageId = image.ImageId };
                        UnitOfWork.NewsImages.Insert(newsImage);
                    }
                }
            }
            UnitOfWork.News.Update(news);
            UnitOfWork.SaveChanges();
            return news;
        }

        public void DeleteNews(Guid id)
        {
            var news = UnitOfWork.News.Find(id);
            if (news != null)
            {
                news.IsDeleted = true;
                UnitOfWork.News.Update(news);
            }
            else
            {
                throw new NotFoundErrorException();
            }

            UnitOfWork.SaveChanges();
        }

        public List<byte[]> GetNewsImages(Guid newsId)
        {
            var images = UnitOfWork.NewsImages.Where(ni => ni.NewsId == newsId)
               .Select(ni => ni.Image.Content)
               .ToList();


            return images;
        }

        public void AddCommentToNews(Guid newsId, string comment)
        {
            var com = new Comment();
            com.NewsId = newsId;
            com.AuthorId = CurrentUser.Id;
            com.CommentId = Guid.NewGuid();
            com.ParentCommentId = com.CommentId;
            com.PostDate = DateTime.Now;
            com.Message = comment;
            AddCommentValidator.Validate(com).ThenThrow(com);
            UnitOfWork.Comments.Insert(com);
            UnitOfWork.SaveChanges();
        }
    }
}
