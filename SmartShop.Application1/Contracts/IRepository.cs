using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Application1.Contracts
{
    public interface IRepository<T, TID> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(TID id);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        int Save();


    }
}
