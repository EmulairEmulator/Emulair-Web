using Emulair.Common;
using EmulairWEB.Context;
using EmulairWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
