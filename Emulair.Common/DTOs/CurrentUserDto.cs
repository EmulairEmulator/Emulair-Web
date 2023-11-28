using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulair.Common.DTOs
{
    public class CurrentUserDto
    {

        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Role { get; set; }

    }
}
