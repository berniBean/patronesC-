using DessingPatterns.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessingsPatterns.Repository
{
    public interface IUnitOfWork
    {
        public IRepository<Curso> Cursos { get; }
        public IRepository<Instructor> Instructores { get; }
        public IRepository<Precio> Precios { get; }
        public IRepository<Comentario> Comentarios { get; }
        public IRepository<Cursoinstructor> CursosInstructores { get; }

        public void Save();
    }
}
