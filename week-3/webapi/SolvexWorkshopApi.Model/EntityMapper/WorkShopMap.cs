using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolvexWorkshopApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolvexWorkshopApi.Model.EntityMapper
{
    public class WorkShopMap : IEntityTypeConfiguration<WorkShop>
    {
        public void Configure(EntityTypeBuilder<WorkShop> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.EndDate);
        }
    }
}
