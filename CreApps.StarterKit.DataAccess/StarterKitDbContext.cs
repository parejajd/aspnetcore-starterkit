using CreApps.StarterKit.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreApps.StarterKit.DataAccess
{
    public class StarterKitDbContext : DbContext
    {
        public StarterKitDbContext(DbContextOptions<StarterKitDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RemovePluralizingTableNameConvention();

            modelBuilder.Entity<TicketType>().HasData(
                new TicketType
                {
                    Id = 1,
                    TicketTypeName = "Problem"
                },
                new TicketType
                {
                    Id = 2,
                    TicketTypeName = "Incident"
                },
                new TicketType
                {
                    Id = 3,
                    TicketTypeName = "New Requirement"
                }
            );

            modelBuilder.Entity<Priority>().HasData(
                new Priority
                {
                    Id = 1,
                    PriorityName = "Critical"
                },
                new Priority
                {
                    Id = 2,
                    PriorityName = "Urgent"
                },
                new Priority
                {
                    Id = 3,
                    PriorityName = "Medium"
                },
                new Priority
                {
                    Id = 4,
                    PriorityName = "Low"
                }
            );

            modelBuilder.Entity<Status>().HasData(
                new Status
                {
                    Id = 1,
                    StatusName = "Pending"
                },
                new Status
                {
                    Id = 2,
                    StatusName = "In progress"
                },
                new Status
                {
                    Id = 3,
                    StatusName = "Resolved"
                },
                new Status
                {
                    Id = 4,
                    StatusName = "Closed"
                },
                new Status
                {
                    Id = 5,
                    StatusName = "Discarted"
                }
            );

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = 1,
                    Subject = "Create DB",
                    Description = "I need create a bd to save tickets",
                    PriorityId = 1,
                    StatusId = 1,
                    TypeId = 1
                }
                );
        }
    }
}
