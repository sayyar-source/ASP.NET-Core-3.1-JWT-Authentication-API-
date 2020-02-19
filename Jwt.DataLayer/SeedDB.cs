using Jwt.DataLayer.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jwt.Model.Models;

namespace Jwt.DataLayer
{
   public class SeedDB
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<DataBaseContext>();
            context.Database.EnsureCreated();
            if (!context.Users.Any())
            {
                User user=new User
                {
                    Email = "ali@gmail.com",
                    FirstName="Muhammed",
                    LastName="sayyar",
                    Password="123",
                    Phone="45454",
                    Username="ali"
                };
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
