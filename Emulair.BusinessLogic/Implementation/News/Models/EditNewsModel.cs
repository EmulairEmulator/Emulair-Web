using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulair.BusinessLogic.Implementation.News.Models
{
    public class EditNewsModel
    {
        public Guid NewsId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
