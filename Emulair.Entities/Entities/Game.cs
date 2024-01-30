using System;
using System.Collections.Generic;

namespace EmulairWEB.Models
{
    public partial class Game
    {
        public Game()
        {
            Achievements = new HashSet<Achievement>();
            Reviews = new HashSet<Review>();
            Stats = new HashSet<Stat>();
            UserGames = new HashSet<UserGame>();
        }

        public Guid GameId { get; set; }
        public Guid IconId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Achievement> Achievements { get; set; }
        public virtual Image Icon { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Stat> Stats { get; set; }
        public virtual ICollection<UserGame> UserGames { get; set; }
    }
}
