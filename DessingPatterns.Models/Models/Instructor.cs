using System;
using System.Collections.Generic;

#nullable disable

namespace DessingPatterns.Models.Models
{
    public partial class Instructor
    {
        public Instructor()
        {
            Cursoinstructors = new HashSet<Cursoinstructor>();
        }

        public int IdInstructor { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Grado { get; set; }
        public string FotoPerfil { get; set; }

        public virtual ICollection<Cursoinstructor> Cursoinstructors { get; set; }
    }
}
