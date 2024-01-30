using Emulair.Common;
using EmulairWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmulairWEB.Models
{
    public partial class Comment : IEntity
    {
        public Guid CommentId { get; set; }

        public Guid ParentCommentId { get; set; }

        public string Message { get; set; } = null!;

        public DateTime PostDate { get; set; }

        public Guid AuthorId { get; set; }

        public Guid NewsId { get; set; }

        public bool IsDeleted { get; set; }

        public virtual User Author { get; set; } = null!;

        public virtual ICollection<Comment> InverseParentComment { get; set; } = new List<Comment>();

        public virtual News1 News { get; set; } = null!;

        public virtual Comment ParentComment { get; set; } = null!;
    }
}
