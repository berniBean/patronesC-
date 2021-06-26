using DessingPattern.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessingPattern.RepositoryPattern
{

    public class CursoRepository : ICursoRepository
    {

        private cursosonlineContext _context;
        public CursoRepository(cursosonlineContext context)
        {
            _context = context;
        }

        public void Add(Curso data) =>  _context.Cursos.Add(data);
        

        public void Delete(int id)
        {
           var curso = _context.Cursos.Find(id);
            _context.Cursos.Remove(curso);
        }

        public IEnumerable<Curso> Get() => _context.Cursos.ToList();

        public Curso Get(int id) => _context.Cursos.Find(id);

        public void Update(Curso data) => _context.Entry(data).State = EntityState.Modified;

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
