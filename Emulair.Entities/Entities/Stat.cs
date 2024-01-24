using System;
using System.Collections.Generic;

namespace EmulairWEB.Models
{
    public partial class Stat
    {
        public Stat()
        {
            UserStats = new HashSet<UserStat>();
        }

        public Guid StatId { get; set; }
        public Guid? GameId { get; set; }
        public string? Name { get; set; }

        public virtual Game? Game { get; set; }
        public virtual ICollection<UserStat> UserStats { get; set; }
    }
}
