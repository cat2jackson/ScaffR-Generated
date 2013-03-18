#region credits
// ***********************************************************************
// Assembly	: DemoApplication.Infrastructure
// Author	: Rod Johnson
// Created	: 03-16-2013
// 
// Last Modified By : Rod Johnson
// Last Modified On : 03-17-2013
// ***********************************************************************
#endregion
namespace DemoApplication.Infrastructure.Data.Seeders
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Core.Model;

    #endregion

    public partial class MembershipDataSeeder
    {
        public void Seed(DataContext context)
        {
            new List<Role>()
                {
                    new Role()
                        {
                            RoleId = 1,
                            RoleName = "Super Admin"
                        }
                }.ForEach(a => context.Roles.AddOrUpdate(a));

            new List<User>()
                {
                    new User()
                        {
                            UserId = 1,
                            Email = "webmaster@scaffr.com",
                            Username = "admin",
                            FirstName = "Rod",
                            LastName = "Johnson",
                            LastLoginDate = DateTime.Now,
                            Password = "admin",
                            IsApproved = true,							
                            Gender = Gender.Male,
                            Address = "Admin address",
                            PhoneNumber = "555-555-5555"
                        }
                }.ForEach(u => context.Users.AddOrUpdate(u));

            var existsInRole = context.UserRoles.Any(ur => ur.UserId == 1 && ur.UserId == 1);
                               
            if (!existsInRole)
            {
                new List<UserRole>()
                {
                    new UserRole()
                        {
                            RoleId = 1,
                            UserId = 1
                        }
                }.ForEach(ur => context.UserRoles.Add(ur));
            }

        }
    }
}