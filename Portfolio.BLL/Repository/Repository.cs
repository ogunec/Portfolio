using Microsoft.EntityFrameworkCore;
using Portfolio.BLL.Abstract;
using Portfolio.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.BLL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly Context _db;
        internal DbSet<T> table;
        public Repository(Context db)
        {
            _db = db;
            table = db.Set<T>();
        }
        private void Save()
        {
            _db.SaveChanges();
        }
        public void Add(T entity)
        {
            table.Add(entity);
            Save();
        }

        public void Delete(T entity)
        {
            table.Remove(entity);
            Save();
        }

        public List<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(int? id)
        {
            return table.Find(id);
        }

        public void Update(T entity)
        {
            table.Update(entity);
            Save();
        }
    }
}
