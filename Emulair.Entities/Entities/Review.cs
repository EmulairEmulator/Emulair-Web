using System;
using System.Collections.Generic;

namespace EmulairWEB.Models
{
    public partial class Review
    {
        public Guid ReviewId { get; set; }
        public Guid? GameId { get; set; }
        public Guid? UserId { get; set; }
        public int? Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime? ReviewDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Game? Game { get; set; }
        public virtual User? User { get; set; }
    }
}
