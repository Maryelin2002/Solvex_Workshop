using Microsoft.EntityFrameworkCore;
using SolvexWorkshopApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SolvexWorkshopApi.Model
{
    public interface IApplicationDbContext
    {
        DbSet<WorkShop> WorkShop { get; set; }
        DbSet<WorkShopDay> WorkShopDay { get; set; }
        DbSet<WorkShopMember> WorkShopMember { get; set; }
        DbSet<Document> Document { get; set; }

        Task<int> SaveChangesAsync();
    }
}
