using Microsoft.EntityFrameworkCore;
using SolvexWorkshopApi.Model.Entities;
using SolvexWorkshopApi.Model.EntityMapper;
using System.Threading.Tasks;

namespace SolvexWorkshopApi.Model
{
    public class WorkShopContext : DbContext, IWorkShopContext
    {
        public WorkShopContext()
        {

        }
        public WorkShopContext(DbContextOptions options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<WorkShop> WorkShop { get; set; }
        public DbSet<WorkShopDay> WorkShopDay { get; set; }
        public DbSet<WorkShopMember> WorkShopMember { get; set; }
        public DbSet<Document> Document { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkShopMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new WorkShopDayMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new WorkShopMemberMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DocumentMap());
            base.OnModelCreating(modelBuilder);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
