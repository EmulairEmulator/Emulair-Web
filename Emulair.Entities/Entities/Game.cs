using System;
using System.Collections.Generic;

namespace EmulairWEB.Models
{
    public partial class Game
    {
        public Game()
        {
            Reviews = new HashSet<Review>();
        }

        public Guid GameId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}
