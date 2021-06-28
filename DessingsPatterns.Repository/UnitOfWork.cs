using DessingPatterns.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessingsPatterns.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private cursosonlineContext _context;
        private IRepository<Curso> _cursos;
        private IRepository<Instructor> _instructor;
        private IRepository<Precio> _precio;
        private IRepository<Comentario> _comentario;
        private IRepository<Cursoinstructor> _cursoInstructor;
        public UnitOfWork(cursosonlineContext context)
        {
            _context = context;
        }

        public IRepository<Curso> Cursos
        {
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

        public IRepository<Precio> Precios
        {
            get
            {
                return _precio == null ? _precio = new Repository<Precio>(_context) : _precio;
            }
        }

        public IRepository<Comentario> Comentarios
        {
            get
            {
                return _comentario == null ? _comentario = new Repository<Comentario>(_context) : _comentario;
            }
        }

        public IRepository<Cursoinstructor> CursosInstructores
        {
            get
            {
                return _cursoInstructor == null ? _cursoInstructor = new Repository<Cursoinstructor>(_context) : _cursoInstructor;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
