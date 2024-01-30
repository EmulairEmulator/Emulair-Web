using Emulair.BusinessLogic.Implementation.Game;
using Emulair.Code.Base;
using Emulair.WebApp.Code.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emulair.Controllers
{
    [Authorize]
    public class GameController : BaseController
    {
        private readonly GameService gameService;
        private readonly IConfiguration Configuration;

        public GameController(ControllerDependencies dependencies, GameService service, IConfiguration configuration) : base(dependencies)
        {
            gameService = service;
            Configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var games = gameService.GetGames();
            return View(games);
        }
    }
}
