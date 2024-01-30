using Emulair.Common;
using Emulair.DataAccess.Context;
using EmulairWEB.Models;
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
        private IRepository<Image> images;
        public IRepository<Image> Images => images ?? (images = new BaseRepository<Image>(Context));
        private IRepository<Comment> comments;
        public IRepository<Comment> Comments => comments ?? (comments = new BaseRepository<Comment>(Context));
        private IRepository<News1> news;
        public IRepository<News1> News => news ?? (news = new BaseRepository<News1>(Context));
        private IRepository<NewsImage> newsImages;
        public IRepository<NewsImage> NewsImages => newsImages ?? (newsImages = new BaseRepository<NewsImage>(Context));
        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
