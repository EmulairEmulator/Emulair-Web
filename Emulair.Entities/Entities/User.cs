using Emulair.Entities.Entities;
using System;
using System.Collections.Generic;

namespace EmulairWEB.Models
{
    public partial class User
    {
        public User()
        {
            Reviews = new HashSet<Review>();
            UserAchievements = new HashSet<UserAchievement>();
            UserGames = new HashSet<UserGame>();
            UserStats = new HashSet<UserStat>();
        }

        public Guid UserId { get; set; }
        public int? RoleId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<UserAchievement> UserAchievements { get; set; }
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public virtual ICollection<News1> News { get; set; } = new List<News1>();
        public virtual ICollection<UserGame> UserGames { get; set; }
        public virtual ICollection<UserStat> UserStats { get; set; }
    }
}
