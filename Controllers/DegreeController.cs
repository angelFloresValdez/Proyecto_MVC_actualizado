using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstProyectWithLineCommand.Models;

namespace MyFirstProyectWithLineCommand.Controllers
{
    public class DegreeController : Controller
    {
         private readonly ILogger<DegreeController> _logger;
        public DegreeController(ILogger<DegreeController> logger)
        {
             _logger = logger;
        }

        public IActionResult DegreeAdd()
        {
            return View();  
        }   

        
         [HttpPost]
         public IActionResult DegreeAdd(DegreeModel degree)
        {
           if(!ModelState.IsValid)
           {
            _logger.LogWarning("El objeto no es valido");
            return View();
           }

            _logger.LogInformation("El objeto es valido");
         
            return Redirect("DegreeList");
        }   

        public IActionResult DegreeList()
    {
        /*Seccion de listado de carrera*/
        _logger.LogInformation("Esto es un mensaje al cargar las carreras");
         //Crear objeto de carrera
         DegreeModel Carrera=new DegreeModel();  
        Carrera.Nombre="Ingenieria en Tecnologias de la información";

         DegreeModel Carrera2=new DegreeModel();  
        Carrera2.Nombre="Licenciatura en administracion de empresas";

         DegreeModel Carrera3=new DegreeModel();  
        Carrera3.Nombre="Licenciatura en Contabilidad"; 

         //objeto de lista de carreras
         List<DegreeModel>list=new List<DegreeModel>(); 
        list.Add(Carrera);
        list.Add(Carrera2);
        list.Add(Carrera3);

        return View(list);
    }

          public IActionResult DegreeEdit(Guid Id)
    {
            DegreeModel carrera=new DegreeModel();  
           carrera.Id=Id;
            carrera.Nombre="Carrera cargada";
            return View(carrera);
    }

        [HttpPost]
        public IActionResult DegreeEdit(DegreeModel carrera)
        {
             if(!ModelState.IsValid)
           {
            _logger.LogWarning("El objeto no es valido");
            carrera.Nombre="Carrera no es valida";
            return View(carrera);
           }

            _logger.LogInformation("El objeto es valido");
         
            return Redirect("DegreeList");
 
        }

         public IActionResult DegreeShowToDelete(Guid Id)
         {
            //con el id se buscara en la base de datos el registro correspondiente
            //despues se le asigna al objeto
             DegreeModel carrera=new DegreeModel();  
            carrera.Id=Id;
            carrera.Nombre="Carrera para borrar";
            return View(carrera);
            
         }

          public IActionResult DegreeDeleted()
          {
            /*Borra el registro*/
            return Redirect ("DegreeList");
          }

    }

  
}