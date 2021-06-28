using DessingPattern.FactoryPattern;
using DessingPattern.Models;
using DessingPattern.RepositoryPattern;
using DessingPattern.UnitOfWorkPattern;
using System;

namespace DessingPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //using (var context = new cursosonlineContext())
            //{
            //    var cursoRepository = new Repository<Curso>(context);
            //    var curso = new Curso()
            //    {
            //        Titulo = "Aerobot Planet Boot Camp",
            //        Descripcion = "Arduino boot camp",
            //        FechaPublicacion = new DateTime(25 / 06 / 2021)
            //    };

            //    cursoRepository.Add(curso);
            //    cursoRepository.save();

            //    foreach (var item in cursoRepository.Get())
            //    {
            //        Console.WriteLine(item.Titulo);
            //    }

            //    var instructorRepository = new Repository<Instructor>(context);
            //    var instructor = new Instructor() { Nombre = "Hector", Apellidos = "de leon", Grado = "Doctorado" };
            //    instructorRepository.Add(instructor);
            //    instructorRepository.save();

            //    foreach (var item in instructorRepository.Get())
            //    {
            //        Console.WriteLine(item.Nombre);
            //    }
            //}

            using(var context = new cursosonlineContext())
            {
                var unitOfWork = new UnitOfWork(context);

                var curso = unitOfWork.Cursos;

                var cursos = new Curso()
                {
                    Idcurso = 11,
                    Titulo = "curso modificado",
                    FechaPublicacion = new DateTime(2021,05,01)
                };

                curso.Update(cursos);

                curso.save();


                foreach (var item in curso.Get())
                {
                    Console.WriteLine(item.Titulo, item.FechaPublicacion);
                }
            }

            




        }
    }
}
