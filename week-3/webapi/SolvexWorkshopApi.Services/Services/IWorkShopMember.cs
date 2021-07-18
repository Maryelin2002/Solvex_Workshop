using System;
using System.Collections.Generic;
using System.Text;
using SolvexWorkshopApi.Model.Entities;

namespace SolvexWorkshopApi.Services.Services
{
    interface IWorkShopMember
    {
        IEnumerable<WorkShopMember> GetAllWorkShopMembers();

        WorkShopMember GetWorkShopMember(int id);
        void InsertWorkShopMember(WorkShopMember workShopMember);
        void UpdateWorkShopMember(WorkShopMember workShopMember);
        void DeleteWorkShopMember(int id);
    }
}
