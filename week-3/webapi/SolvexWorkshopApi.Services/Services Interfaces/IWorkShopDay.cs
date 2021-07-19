using SolvexWorkshopApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolvexWorkshopApi.Services.Services
{
    public interface IWorkShopDay
    {
        IEnumerable<WorkShopDay> GetAllWorkShopDays();

        WorkShopDay GetWorkShopDay(int id);
        void InsertWorkShopDay(WorkShopDay workShopDay);
        void UpdateWorkShopDay(WorkShopDay workShopDay);
        void DeleteWorkShopDay(int id);
    }
}
