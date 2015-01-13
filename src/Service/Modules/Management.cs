using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoRepository;
using Nancy;
using Service.Models;

namespace Service.Modules
{
    public class Management : NancyModule
    {
        public Management()
            : base("account/management")
        {
            var shopPermission = new Dictionary<string, Dictionary<string, string[]>>
            {
                {
                    "shop", new Dictionary<string, string[]>
                    {
                        {"brand", new[] {"create", "update", "delete"} },
                        {"category", new[] {"create", "update", "delete"} }
                    }
                },
                {
                    "office", new Dictionary<string, string[]>
                    {
                        {"pages", new[] {"create", "update", "delete"} },
                        {"form", new[] {"create", "update", "delete"} }
                    }
                }
            };

            var role = new Role
            {
                Name = "admin",
                Title = @"مدیریت",
                IsActive = true,
                IsLimitedByDate = false,
                IsLimitedInDay = false,
                IsLimitedInWeek = false,
                IpRange = new []{"192.168.0.1"},
                Permissions = shopPermission
            };

            var user = new Models.User
            {
                EMail = "a@b.com",
                FriendlyName = "Soren Z.Vand",
                IsActive = true,
            };

            Post["/addRole"] = _ =>
            {
                var roleRepo = new MongoRepository<Role>();

                
                //roleRepo.Add(role);

                return roleRepo.First();

                //.Select(s => s.Value)
                //.ToList();

            };

            Post["/addUser"] = _ =>
            {
                var userRepo = new MongoRepository<Models.User>();

                var roleRepo = new MongoRepository<Role>();
                
                roleRepo.Add(role);

                user.RoleIds.Add(role.Id);

                userRepo.Add(user);


                return userRepo.First();
            };

        }
    }
}
