using SolvexWorkshopApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolvexWorkshopApi.Services.Services
{
    public interface IWorkShopService
    {
        IEnumerable<WorkShop> GetAllWorkShops();

        WorkShop GetWorkShop(int id);
        void InsertWorkShop(WorkShop workShop);
        void UpdateWorkShop(WorkShop workShop);
        void DeleteWorkShop(int id);
    }
}
