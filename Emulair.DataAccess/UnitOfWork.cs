using Emulair.Common;
using EmulairWeb.Context;
using EmulairWEB.Models;

namespace Emulair.DataAccess
{
    public class UnitOfWork
    {
        private readonly EmulairWebContext Context;

        public UnitOfWork(EmulairWebContext context)
        {
            this.Context = context;
        }

        private IRepository<User> users;
        public IRepository<User> Users => users ?? (users = new BaseRepository<User>(Context));
        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
