using System;
using System.Collections.Generic;
using System.Text;
using SolvexWorkshopApi.Model.Entities;
using SolvexWorkshopApi.Model.Repository;

namespace SolvexWorkshopApi.Services.Services
{
    public class WorkShopMemberService : IWorkShopMember
    {
        private IRepository<WorkShopMember> _repository;
        public WorkShopMemberService(IRepository<WorkShopMember> repository)
        {
            _repository = repository;
        }
        public void DeleteWorkShopMember(int id)
        {
            WorkShopMember workShopMember = GetWorkShopMember(id);
            _repository.Remove(workShopMember);
            _repository.SaveChanges();
        }

        public IEnumerable<WorkShopMember> GetAllWorkShopMembers()
        {
            return _repository.GetAll();
        }

        public WorkShopMember GetWorkShopMember(int id)
        {
            return _repository.Get(id);
        }

        public void InsertWorkShopMember(WorkShopMember workShopMember)
        {
            _repository.Insert(workShopMember);
        }

        public void UpdateWorkShopMember(WorkShopMember workShopMember)
        {
            _repository.Update(workShopMember);
        }
    }
}
