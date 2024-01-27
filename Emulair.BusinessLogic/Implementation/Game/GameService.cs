using Emulair.BusinessLogic.Base;
using Emulair.BusinessLogic.Implementation.Game.Models;
using EmulairWEB.Models;
using Microsoft.EntityFrameworkCore;

namespace Emulair.BusinessLogic.Implementation.Game
{
    public class GameService : BaseService
    {
        public GameService(ServiceDependencies dependencies) : base(dependencies)
        {

        }

        public List<GameListItem> GetGames()
        {
            var gameList = new List<GameListItem>();

            var userGames = UnitOfWork.UserGames
                            .Get()
                            .Where(userGame => userGame.UserId == CurrentUser.Id)
                            .Include(userGame => userGame.Game)
                            .OrderByDescending(userGame => userGame.LastPlayed)
                            .ToList();

            if (userGames == null)
            {
                return gameList;
            }

            foreach (var userGame in userGames)
            {
                var gameListItem = Mapper.Map<UserGame, GameListItem>(userGame);

                gameListItem.TotalAchievements = UnitOfWork.Achievements
                                                    .Get()
                                                    .Where(achievement => achievement.GameId == userGame.GameId)
                                                    .Count();

                gameListItem.TotalAchievementsUnlocked = UnitOfWork.UserAchievements
                                                            .Get()
                                                            .Where(userAchievement => userAchievement.UserId == CurrentUser.Id
                                                                    && userAchievement.GameId == userGame.GameId)
                                                            .Where(userAchievement => userAchievement.IsUnlocked == true)
                                                            .Count();

                gameList.Add(gameListItem);
            }

            return gameList;
        }
    }
}
