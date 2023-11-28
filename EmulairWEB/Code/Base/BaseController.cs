using Emulair.Code.Base;
using Emulair.Common.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Emulair.WebApp.Code.Base
{
    public class BaseController : Controller
    {
        protected readonly CurrentUserDto CurrentUser;

        public BaseController(ControllerDependencies dependencies)
            : base()
        {
            CurrentUser = dependencies.CurrentUser;
        }
    }
}
