using System;
using System.Collections.Generic;

#nullable disable

namespace DessingPattern.Models
{
    public partial class Curso
    {
        public Curso()
        {
            Comentarios = new HashSet<Comentario>();
            Cursoinstructors = new HashSet<Cursoinstructor>();
            Precios = new HashSet<Precio>();
        }

        public int Idcurso { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public string FotoPortada { get; set; }

        public virtual ICollection<Comentario> Comentarios { get; set; }
        public virtual ICollection<Cursoinstructor> Cursoinstructors { get; set; }
        public virtual ICollection<Precio> Precios { get; set; }
    }
}
