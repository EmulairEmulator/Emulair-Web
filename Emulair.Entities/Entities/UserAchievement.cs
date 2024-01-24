using System;
using System.Collections.Generic;

namespace EmulairWEB.Models
{
    public partial class UserAchievement
    {
        public Guid UserId { get; set; }
        public Guid AchievementId { get; set; }
        public bool? IsUnlocked { get; set; }
        public byte[] UnlockedAt { get; set; } = null!;

        public virtual Achievement Achievement { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
