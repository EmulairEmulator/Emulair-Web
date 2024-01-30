using Emulair.Entities.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulair.BusinessLogic.Implementation.News.Models
{
    public class NewsModel
    {
        public Guid NewsId { get; set; }
        [Required(ErrorMessage = "Please enter the Title.")]
        public string Title { get; set; } = null!;
        [Required(ErrorMessage = "Please enter the Description.")]
        public string Description { get; set; } = null!;
        public Guid AuthorId { get; set; }
        public string Author { get; set; }

        public DateTime PostDate { get; set; }
        public List<byte[]> Images { get; set; }
        public List<Comment> Comments { get; set; }
        public Comment NewComment { get; set; }
        public List<Comment> Replies { get; set; }
        public List<IFormFile> formFiles { get; set; }
        public NewsModel()
        {
            Images = new List<byte[]>();
            Comments = new List<Comment>();
            Replies = new List<Comment>();
        }
    }
}
