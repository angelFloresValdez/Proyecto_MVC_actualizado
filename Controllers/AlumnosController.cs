using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstProyectWithLineCommand.Models;

namespace MyFirstProyectWithLineCommand.Controllers
{
    public class AlumnosController : Controller
    {
          private readonly ILogger<AlumnosController> _logger;
        public AlumnosController(ILogger<AlumnosController> logger)
        {
             _logger = logger;
        }

       
        public IActionResult AlumnosAdd()
        {
            return View();
        }

        [HttpPost]
         public IActionResult AlumnosAdd(StundetModel alumno)
        {
           if(!ModelState.IsValid)
           {
            _logger.LogWarning("El objeto no es valido");
            return View();
           }

            _logger.LogInformation("El objeto es valido");
         
            return Redirect("studentList");
        }   

        public IActionResult StudentList()
        {
            // Crear objetos de alumnos
            StundetModel alumno = new StundetModel
            {
                Nombre = "Ángel Flores Valdez",
                Carrera = "Ingeniería en sistemas",
                matricula = 44546,
                Edad = 18,
                Sexo = "Masculino"
            };

            StundetModel alumno2 = new StundetModel
            {
                Nombre = "Mario Alberto Loredo",
                Carrera = "Contabilidad",
                matricula = 43722,
                Edad = 18,
                Sexo = "Masculino"
            };

            StundetModel alumno3 = new StundetModel
            {
                Nombre = "Julian Macias Lara",
                Carrera = "Administración de empresas",
                matricula = 44728,
                Edad = 19,
                Sexo = "Masculino"
            };

            // Objetos de lista de alumnos
            List<StundetModel> list = new List<StundetModel>
            {
                alumno,
                alumno2,
                alumno3
            };

            return View(list);
        }

        public IActionResult AlumnosSave()
        {
            // Guardar info
            return Redirect("StudentList");
        }

        public IActionResult AlumnosShowAndEdit(Guid Id)
        {
            StundetModel alumno = new StundetModel();
            
                alumno.Id = Id;
                alumno.Nombre = "Alumno cargado";
            return View(alumno);
        }

        public IActionResult AlumnosEdit(Guid Id)
        {
            StundetModel Alumno=new StundetModel();  
           Alumno.Id=new Guid();
            Alumno.Nombre="Carrera cargada";
            return View(Alumno);
        }

         [HttpPost]
         public IActionResult AlumnosEdit(StundetModel estudiante)
        {
              if(!ModelState.IsValid)
           {
            _logger.LogWarning("El objeto no es valido");
            estudiante.Nombre="Carrera no es valida";
            return View(estudiante);
           }

            _logger.LogInformation("El objeto es valido");
         
            return Redirect("StudentList");
        }


        public IActionResult AlumnosShowToDelete(Guid Id)
        {
        StundetModel alumno = new StundetModel();
            
                alumno.Id = Id;
                alumno.Nombre = "Alumno para borrar";
            return View(alumno);
        }

        public IActionResult AlumnosDeleted()
        {
            // Borrar el registro
            return Redirect("StudentList");
        }
    }
}