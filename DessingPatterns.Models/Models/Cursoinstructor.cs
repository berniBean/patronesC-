using System;
using System.Collections.Generic;

#nullable disable

namespace DessingPatterns.Models.Models
{
    public partial class Cursoinstructor
    {
        public int IdInstructor { get; set; }
        public int Idcurso { get; set; }

        public virtual Instructor IdInstructorNavigation { get; set; }
        public virtual Curso IdcursoNavigation { get; set; }
    }
}
