using System;
using System.Collections.Generic;

namespace EmulairWEB.Models
{
    public partial class UserGame
    {
        public Guid UserId { get; set; }
        public Guid GameId { get; set; }
        public int? TotalHoursPlayed { get; set; }
        public DateTime? LastPlayed { get; set; }

        public virtual Game Game { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
