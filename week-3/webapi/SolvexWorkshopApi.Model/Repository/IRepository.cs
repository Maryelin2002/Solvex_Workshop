using SolvexWorkshopApi.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolvexWorkshopApi.Model.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int Id);
        void Insert(T entity);
        void Update(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
