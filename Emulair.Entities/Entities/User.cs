using Emulair.Common;
using System;
using System.Collections.Generic;

namespace EmulairWEB.Models
{
    public partial class User : IEntity
    {
        public User()
        {
            Reviews = new HashSet<Review>();
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
        public virtual ICollection<UserStat> UserStats { get; set; }
    }
}
