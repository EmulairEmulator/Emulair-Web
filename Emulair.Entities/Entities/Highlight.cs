using System;
using System.Collections.Generic;

namespace EmulairWEB.Models
{
    public partial class Highlight
    {
        public Guid HighlightId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? LinkUrl { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
