using CreApps.StarterKit.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreApps.StarterKit.Test.DataAccess
{
    public class InMemoryDbContextFactory
    {
        public StarterKitDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<StarterKitDbContext>()
                            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                            .Options;
            var dbContext = new StarterKitDbContext(options);

            return dbContext;
        }
    }
}
