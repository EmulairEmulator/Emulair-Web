using Emulair.Common;
using EmulairWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulair.Entities.Entities
{
    public partial class NewsImage : IEntity
    {
        public Guid NewsImageId { get; set; }

        public Guid NewsId { get; set; }

        public Guid ImageId { get; set; }

        public virtual Image Image { get; set; } = null!;

        public virtual News1 News { get; set; } = null!;
    }
}
