using DessingPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessingPattern.RepositoryPattern
{
    public interface ICursoRepository
    {
        IEnumerable<Curso> Get();
        Curso Get(int id);
        void Add(Curso data);
        void Delete(int id);
        void Update(Curso data);
        
        void save();
    }
}
