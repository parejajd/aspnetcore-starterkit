using CreApps.StarterKit.DataAccess;
using CreApps.StarterKit.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreApps.StarterKit.Test.Web.DataAccess
{
    public class InMemoryDbContextFactory
    {
        public StarterKitDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<StarterKitDbContext>()
                            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                            .Options;
            var dbContext = new StarterKitDbContext(options);

            dbContext.Add<Priority>(
             new Priority
             {
                 Id = 5,
                 PriorityName = "Important"
             });

            dbContext.SaveChanges();

            return dbContext;
        }
    }
}
