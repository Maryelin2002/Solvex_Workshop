using SolvexWorkshopApi.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolvexWorkshopApi.Model.Repository
{
    public class WorkShopMember<T> : IRepository<T> where T : BaseEntity
    {
        public T Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
