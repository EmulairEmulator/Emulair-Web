using Emulair.BusinessLogic.Implementation.News;
using Emulair.BusinessLogic.Implementation.News.Models;
using Emulair.Code.Base;
using Emulair.Common;
using Emulair.Entities.Entities;
using Emulair.WebApp.Code.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emulair.Controllers
{
    public class NewsController : BaseController
    {
        private readonly ImagesExtension _imageConverter;
        private readonly NewsService Service;

        public NewsController(ControllerDependencies dependencies, NewsService service, ImagesExtension imageConverter)
           : base(dependencies)
        {
            this.Service = service;
            _imageConverter = imageConverter;
        }
        public IActionResult Index()
        {
            var user = CurrentUser.Id;
            var newsList = Service.DisplayNews();
            return View(newsList);
        }
        [HttpGet]
        [Authorize(Roles = "Admin,Writer")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Writer")]
        public IActionResult Create([FromForm] NewsModel newsModel)
        {
            var imageBytesList = _imageConverter.ConvertImages(newsModel.formFiles);
            Service.CreateNews(newsModel, imageBytesList);
            return Ok(true);
        }
        public IActionResult Details(Guid id)
        {
            var news = Service.GetNewsById(id);
            news.NewComment = new Comment();
            return View(news);
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Writer")]
        public IActionResult Edit(Guid id)
        {
            var news = Service.GetNewsById(id);
            return View(news);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(NewsModel newsModel, List<IFormFile> images)
        {

            var imageBytesList = _imageConverter.ConvertImages(images);
            var news = Service.EditNews(newsModel, imageBytesList);
            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult Delete(Guid id)
        {
            var news = Service.GetNewsById(id);
            return View(news);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid Id)
        {
            Service.DeleteNews(Id);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [Authorize]
        public IActionResult AddComment(Guid id, string comment)
        {
            Service.AddCommentToNews(id, comment);
            return Ok(true);
        }
    }
}
