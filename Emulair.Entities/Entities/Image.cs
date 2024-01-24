using System;
using System.Collections.Generic;

namespace EmulairWEB.Models
{
    public partial class Image
    {
        public Image()
        {
            AchievementIconCompleteds = new HashSet<Achievement>();
            AchievementIconPendings = new HashSet<Achievement>();
        }

        public Guid ImageId { get; set; }
        public byte[]? Content { get; set; }

        public virtual ICollection<Achievement> AchievementIconCompleteds { get; set; }
        public virtual ICollection<Achievement> AchievementIconPendings { get; set; }
    }
}
