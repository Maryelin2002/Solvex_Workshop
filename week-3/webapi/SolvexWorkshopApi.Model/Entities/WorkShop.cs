using SolvexWorkshopApi.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolvexWorkshopApi.Model.Entities
{
    public class WorkShop : BaseEntity
    {
        public WorkShop()
        {
            Days = new HashSet<WorkShopDay>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ContentSupport { get; set; }
        [NotMapped]
        public virtual ICollection<WorkShopDay> Days { get; set; }

    }
}
