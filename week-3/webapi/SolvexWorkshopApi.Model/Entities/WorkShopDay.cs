using SolvexWorkshopApi.Core.BaseModel;
using SolvexWorkshopApi.Core.Enums;
using System;

namespace SolvexWorkshopApi.Model.Entities
{
    public class WorkShopDay : BaseEntity
    {
        public WeekDay Day { get; set; }
        public WorkShopDayMode Mode { get; set; }
        public string ModeLocation { get; set; }
        public TimeSpan StartHour { get; set; }
        public TimeSpan? EndHour { get; set; }
    }
}
