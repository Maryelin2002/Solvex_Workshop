using SolvexWorkshopApi.Model.Entities;
using SolvexWorkshopApi.Model.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolvexWorkshopApi.Services.Services
{
    public class WorkShopService : IWorkShopService
    {
        private IRepository<WorkShop> _repository;

        public WorkShopService(IRepository<WorkShop> repository)
        {
            _repository = repository;
        }
        public void DeleteWorkShop(int id)
        {
            WorkShop workShop = GetWorkShop(id);
            _repository.Remove(workShop);
            _repository.SaveChanges();
        }

        public WorkShop GetWorkShop(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<WorkShop> GetAllWorkShops()
        {
            return _repository.GetAll();
        }

        public void InsertWorkShop(WorkShop workShop)
        {
            _repository.Insert(workShop);
        }

        public void UpdateWorkShop(WorkShop workShop)
        {
            _repository.Update(workShop);
        }
    }
}
