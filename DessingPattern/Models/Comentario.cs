using System;
using System.Collections.Generic;

#nullable disable

namespace DessingPattern.Models
{
    public partial class Comentario
    {
        public int Idcomentario { get; set; }
        public string Alumno { get; set; }
        public int? Puntaje { get; set; }
        public string ComentarioTexto { get; set; }
        public int? Idcurso { get; set; }

        public virtual Curso IdcursoNavigation { get; set; }
    }
}
