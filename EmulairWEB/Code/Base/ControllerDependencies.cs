

using Emulair.Common.DTOs;

namespace Emulair.Code.Base
{
    public class ControllerDependencies
    {
        public CurrentUserDto CurrentUser { get; set; }

        public ControllerDependencies(CurrentUserDto currentUser)
        {
            this.CurrentUser = currentUser;
        }
    }
}
