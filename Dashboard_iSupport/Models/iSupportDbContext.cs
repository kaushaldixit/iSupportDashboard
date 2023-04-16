using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Dashboard_iSupport.Models
{
    public partial class iSupportDbContext : DbContext
    {
        public iSupportDbContext()
        {
        }

        public iSupportDbContext(DbContextOptions<iSupportDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationName> ApplicationName { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<iSupportData> ISupportData { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

    }
}


