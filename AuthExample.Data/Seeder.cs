using AuthExample.Data.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthExample.Data
{
    class Seeder
    {
        internal static void Seed(AuthDbContext context, 
            bool createUsers = false,
            bool createRoles = true,
            bool createUserRoles = false
            )
        {
            if (createUsers) CreateUsers(context);
            if (createRoles) CreateRoles(context);
            if (createUserRoles) CreateUserRoles(context);

        }

        private static void CreateUserRoles(AuthDbContext context)
        {

        }

        private static void CreateRoles(AuthDbContext context)
        {

        }

        private static async void CreateUsers(AuthDbContext context)
        {
            var uManage = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            if (uManage.FindByName("Administrator") == null)
            {
                var userAdmin = new ApplicationUser()
                {
                    UserName = "Administrator"
                };
                await uManage.CreateAsync(userAdmin, "asdfasdf");
            }
        }
    }
}
