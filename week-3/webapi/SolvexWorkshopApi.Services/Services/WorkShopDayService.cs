using SolvexWorkshopApi.Model.Entities;
using SolvexWorkshopApi.Model.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolvexWorkshopApi.Services.Services
{
    public class WorkShopDayService : IWorkShopDay
    {
        private IRepository<WorkShopDay> _repository;
        public WorkShopDayService(IRepository<WorkShopDay> repository)
        {
            _repository = repository;
        }
        public void DeleteWorkShopDay(int id)
        {
            WorkShopDay workShopDay = GetWorkShopDay(id);
            _repository.Remove(workShopDay);
            _repository.SaveChanges();
        }

        public IEnumerable<WorkShopDay> GetAllWorkShopDays()
        {
            return _repository.GetAll();
        }

        public WorkShopDay GetWorkShopDay(int id)
        {
            return _repository.Get(id);
        }

        public void InsertWorkShopDay(WorkShopDay workShopDay)
        {
            _repository.Insert(workShopDay);
        }

        public void UpdateWorkShopDay(WorkShopDay workShopDay)
        {
            _repository.Update(workShopDay);
        }
    }
}
