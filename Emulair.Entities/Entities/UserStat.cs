using System;
using System.Collections.Generic;

namespace EmulairWEB.Models
{
    public partial class UserStat
    {
        public Guid StatId { get; set; }
        public Guid? UserId { get; set; }
        public int? TotalHoursPlayed { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual User? User { get; set; }
    }
}
