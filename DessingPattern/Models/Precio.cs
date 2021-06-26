using System;
using System.Collections.Generic;

#nullable disable

namespace DessingPattern.Models
{
    public partial class Precio
    {
        public int Idprecio { get; set; }
        public decimal? Precioactual { get; set; }
        public decimal? Promocion { get; set; }
        public int? Idcurso { get; set; }

        public virtual Curso IdcursoNavigation { get; set; }
    }
}
