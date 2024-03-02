using Microsoft.EntityFrameworkCore;
using SiteProjects.Models.Database;
using System;

namespace SiteProjects.Models
{
    public class SiteDbcontext : DbContext
    {
        public SiteDbcontext(DbContextOptions<SiteDbcontext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<MasterDesigination> MasterDesigination { get; set; }
        public DbSet<BankInfo> BankInfo { get; set; }
        public DbSet<salary> Salary { get; set; }
        public DbSet<MasterSiteSetup> MasterSiteSetup { get; set; }
        public DbSet<EmployeeBasicInfo> EmployeeBasicInfo { get; set; }
        public DbSet<ImagesExpenses> ImagesExpenses { get; set; }
        public DbSet<DailyAllocation> DailyAllocation { get; set; }
        public DbSet<DailyExpensesRow> DailyExpensesRow { get; set; }
        public DbSet<DailyExpensesHeader> DailyExpensesHeader { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
