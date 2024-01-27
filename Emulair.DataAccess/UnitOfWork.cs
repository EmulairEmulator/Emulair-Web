using Emulair.Common;
using EmulairWeb.Context;
using EmulairWEB.Models;

namespace Emulair.DataAccess
{
    public class UnitOfWork
    {
        private readonly EmulairWEBContext Context;

        public UnitOfWork(EmulairWEBContext context)
        {
            this.Context = context;
        }

        private IRepository<User> users;
        public IRepository<User> Users => users ?? (users = new BaseRepository<User>(Context));

        private IRepository<UserGame> userGames;
        public IRepository<UserGame> UserGames => userGames ?? (userGames = new BaseRepository<UserGame>(Context));

        private IRepository<Achievement> achievements;
        public IRepository<Achievement> Achievements => achievements ?? (achievements = new BaseRepository<Achievement>(Context));

        private IRepository<UserAchievement> userAchievements;
        public IRepository<UserAchievement> UserAchievements => userAchievements ?? (userAchievements = new BaseRepository<UserAchievement>(Context));
        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
