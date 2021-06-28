using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAtronesMVC.Models.ViewModels
{
    public class CursoViewModel
    {
        public int Idcurso { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaPublicacion { get; set; }
    }
}
