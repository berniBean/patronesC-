using DessingsPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using PAtronesMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAtronesMVC.Controllers
{
    public class EscuelaController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public EscuelaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            
            IEnumerable<CursoViewModel> cursos = from d in _unitOfWork.Cursos.Get()
                                                 
                                                 select new CursoViewModel
                                                 {
                                                     Idcurso = d.Idcurso,
                                                     Titulo = d.Titulo,
                                                     Descripcion = d.Descripcion,
                                                     FechaPublicacion = d.FechaPublicacion
                                                 };

            return View("Index", cursos);
        }
    }
}
