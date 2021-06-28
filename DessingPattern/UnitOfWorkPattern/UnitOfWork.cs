using DessingPattern.Models;
using DessingPattern.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessingPattern.UnitOfWorkPattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private cursosonlineContext _context;
        private IRepository<Curso> _cursos;
        private IRepository<Instructor> _instructor;
        public UnitOfWork(cursosonlineContext context)
        {
            _context = context;
        }

        public IRepository<Curso> Cursos {
            get
            {
                return _cursos == null ? _cursos = new Repository<Curso>(_context) : _cursos;
            }
        }
        public IRepository<Instructor> Instructores
        {
            get
            {
                return _instructor == null ? _instructor = new Repository<Instructor>(_context) : _instructor;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
