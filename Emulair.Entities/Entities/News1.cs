using Emulair.Common;
using EmulairWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulair.Entities.Entities
{
    public partial class News1 : IEntity
    {
        public Guid NewsId { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public Guid AuthorId { get; set; }

        public DateTime PostDate { get; set; }

        public bool IsDeleted { get; set; }

        public virtual User Author { get; set; } = null!;

        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public virtual ICollection<NewsImage> NewsImages { get; set; } = new List<NewsImage>();
    }
}
