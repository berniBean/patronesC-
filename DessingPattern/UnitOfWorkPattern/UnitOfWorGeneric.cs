using DessingPattern.Models;
using DessingPattern.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessingPattern.UnitOfWorkPattern
{
    public class UnitOfWorGeneric : IUnitOfWorkGenericcs
    {
        private cursosonlineContext _context;
        private IGenericRepository<Curso> _cursos;
        private IGenericRepository<Instructor> _instructor;
        public UnitOfWorGeneric(cursosonlineContext context)
        {
            _context = context;
        }

        public IGenericRepository<Curso> Cursos
        {
            get
            {
                return _cursos == null ? _cursos = new GenericRepository<Curso>(_context) : _cursos;
            }
        }
        public IGenericRepository<Instructor> Instructores
        {
            get
            {
                return _instructor == null ? _instructor = new GenericRepository<Instructor>(_context) : _instructor;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
