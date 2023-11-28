using AutoMapper;
using Emulair.Common.DTOs;
using Emulair.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulair.BusinessLogic.Base
{
    public class ServiceDependencies
    {
        public IMapper Mapper { get; set; }
        public UnitOfWork UnitOfWork { get; set; }
        public CurrentUserDto CurrentUser { get; set; }

        public ServiceDependencies(IMapper mapper, UnitOfWork unitOfWork, CurrentUserDto currentUser)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            CurrentUser = currentUser;
        }
    }
}
