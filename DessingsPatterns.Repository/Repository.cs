using DessingPatterns.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessingsPatterns.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private cursosonlineContext _context;
        private DbSet<TEntity> _dbSet;

        public Repository(cursosonlineContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public void Add(TEntity data) => _dbSet.Add(data);

        public void Delete(int id)
        {
            var data = Get(id);
            _dbSet.Remove(data);

        }

        public IEnumerable<TEntity> Get() => _dbSet.ToList();

        public TEntity Get(int id) => _dbSet.Find(id);

        public void Update(TEntity data)
        {
            _dbSet.Attach(data);
            _context.Entry(data).State = EntityState.Modified;
        }

        public void save() => _context.SaveChanges();
    }
}
