using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnEFCore_DataBaseFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace HandsOnEFCore_DataBaseFirst.GenericRepository
{
    class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private Batch2DBContext _context = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            _context = new Batch2DBContext();
            table = _context.Set<T>();
        }
        public void Delete(object id)
        {
            T obj = table.Find(id);
            table.Remove(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            table.Update(obj);
            Save();
        }
    }
}
