using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System;

namespace Infrastructure.Data
{
    public class MyDbContextSeed
    {
        public async static Task SeedDataAsync(MyDbContext context, ILoggerFactory loggerFactory)
        {
            try{
                if(!context.Users.Any())
                {
                    var usersData=File.ReadAllText("../Infrastructure/Data/SeedData/user.json");
                    var user=JsonSerializer.Deserialize<List<User>>(usersData);
                    foreach(var items in user)
                    {
                        context.Users.Add(items);
                    }
                    await context.SaveChangesAsync();
                }

                if(!context.Address.Any())
                {
                    var addressData=File.ReadAllText("../Infrastructure/Data/SeedData/address.json");
                    var address=JsonSerializer.Deserialize<List<Address>>(addressData);
                    foreach(var items in address)
                    {
                        context.Address.Add(items);
                    }
                    await context.SaveChangesAsync();
                }

                if(!context.Courses.Any())
                {
                    var coursesData=File.ReadAllText("../Infrastructure/Data/SeedData/course.json");
                    var courses=JsonSerializer.Deserialize<List<Course>>(coursesData);
                    foreach(var items in courses)
                    {
                        context.Courses.Add(items);
                    }
                    await context.SaveChangesAsync();
                }

                if(!context.ExaminationCenters.Any())
                {
                    var examCenterData=File.ReadAllText("../Infrastructure/Data/SeedData/examinationCenter.json");
                    var examCenter=JsonSerializer.Deserialize<List<ExaminationCenter>>(examCenterData);
                    foreach(var items in examCenter)
                    {
                        context.ExaminationCenters.Add(items);
                    }
                    await context.SaveChangesAsync();
                }
            }
            catch(Exception ex)
            {
                var logger=loggerFactory.CreateLogger<MyDbContextSeed>();
                logger.LogError(ex.Message,"Error in the seed data");
            }
        }
    }
}