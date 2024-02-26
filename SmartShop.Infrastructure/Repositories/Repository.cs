
using SmartShop.Application1.Contracts;
using SmartShop.Context.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Infrastructure.Repositories
{
    public class Repository<T, TID> : IRepository<T, TID> where T : class
    {
        private SmartShopDBContext _context;
        private DbSet<T> _dbSet;

        public Repository(SmartShopDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public T Add(T entity)
        {
            return _dbSet.Add(entity).Entity;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsNoTracking().Select(s=>s);
        }
        public T GetById(TID id)
        {
            // return _dbSet.Find(id);
            var entity = _dbSet.Find(id);

            if (entity != null)
            {
                _context.Entry(entity).State = EntityState.Detached;
            }

            return entity;

        }


        public T Update(T entity)
        {
            //return _dbSet.Update(entity).Entity;
            _dbSet.Update(entity);
            _context.SaveChanges();
            _context.Entry(entity).State = EntityState.Detached;
            return entity;

        }


        public int Save()
        {
            return  _context.SaveChanges();
        }


    }
}
