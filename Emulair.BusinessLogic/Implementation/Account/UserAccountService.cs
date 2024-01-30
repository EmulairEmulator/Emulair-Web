using Microsoft.EntityFrameworkCore;
using Emulair.Common.DTOs;
using Emulair.Common.Extensions;
using Emulair.DataAccess;
using Emulair.Entities;
using Emulair.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using Emulair.BusinessLogic.Base;
using EmulairWEB.Models;

namespace Emulair.BusinessLogic.Implementation.Account
{
    public class UserAccountService : BaseService
    {
        private readonly RegisterUserValidator RegisterUserValidator;

        public UserAccountService(ServiceDependencies dependencies)
            : base(dependencies)
        {
            this.RegisterUserValidator = new RegisterUserValidator();
        }

        public CurrentUserDto Login(string email, string password)
        {
            var passwordHash = password; //aici vine alrgoritmul de Hash iar

            var user = UnitOfWork.Users.Get()
                .FirstOrDefault(u => u.Email == email && u.PasswordHash == passwordHash);

            if (user == null)
            {
                return new CurrentUserDto { IsAuthenticated = false };
            }

            var UserNew =  new CurrentUserDto
            {
                Id = user.UserId,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                IsAuthenticated = true,
                Role = "Admin"
            };
            return UserNew;
        }

        public void RegisterNewUser(RegisterModel model)
        {
            RegisterUserValidator.Validate(model).ThenThrow(model);

            var user = Mapper.Map<RegisterModel, User>(model);

            //user.PasswordHash == 

            //user.UserRoles = new List<UserRole>
            //    {
            //        new UserRole { RoleId = (int)RoleTypes.User }
            //    };

            UnitOfWork.Users.Insert(user);
            // trigger mail notifi
            // insert audit 

            UnitOfWork.SaveChanges();
        }

        public List<ListItemModel<string, Guid>> GetUsers()
        {
            return UnitOfWork.Users.Get()
                .Select(u => new ListItemModel<string, Guid>
                {
                    Text = $"{u.FirstName} {u.LastName}",
                    Value = u.UserId
                })
                .ToList();
        }

        public void DisableUser()
        {
        }

        public void ChangePassword() { }
    }
}
