using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolvexWorkshopApi.Model.Entities;
using SolvexWorkshopApi.Model.EntityMapper;

namespace SolvexWorkshopApi.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkShopMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
