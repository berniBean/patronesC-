using DessingPattern.Models;
using DessingPattern.RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessingPattern.UnitOfWorkPattern
{
    public interface IUnitOfWorkGenericcs
    {
        public IGenericRepository<Curso> Cursos { get; }
        public IGenericRepository<Instructor> Instructores { get; }
        public void Save();
    }
}
