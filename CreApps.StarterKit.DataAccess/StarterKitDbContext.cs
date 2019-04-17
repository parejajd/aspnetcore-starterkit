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
                    TicketTypeName = "Problem"
                },
                new TicketType
                {
                    TicketTypeName = "Incident"
                },
                new TicketType
                {
                    TicketTypeName = "New Requirement"
                }
            );

            modelBuilder.Entity<Priority>().HasData(
                new Priority
                {
                    PriorityName = "Critical"
                },
                new Priority
                {
                    PriorityName = "Urgent"
                },
                new Priority
                {
                    PriorityName = "Medium"
                },
                new Priority
                {
                    PriorityName = "Low"
                }
            );

            modelBuilder.Entity<Status>().HasData(
                new Status
                {
                    StatusName = "Pending"
                },
                new Status
                {
                    StatusName = "In progress"
                },
                new Status
                {
                    StatusName = "Resolved"
                },
                new Status
                {
                    StatusName = "Closed"
                },
                new Status
                {
                    StatusName = "Discarted"
                }
            );
        }
    }
}
