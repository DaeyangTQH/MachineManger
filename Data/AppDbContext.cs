using Haichann.MachineManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haichann.MachineManager.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Machine> Machines => Set<Machine>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<MachineStatus> MachineStatuses { get; set; }
        public DbSet<MachineLog> MachineLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "Server=TRANHAI\\HAI_TRAN;" +
                "Database=MachineManagerDb;" +
                "User Id=sa;" +
                "Password=123;" +
                "TrustServerCertificate=True;"
            );


        }
    }
}
