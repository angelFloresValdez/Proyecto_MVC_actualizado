using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstProyectWithLineCommand.Models;

namespace MyFirstProyectWithLineCommand.Controllers

{
    public class ProfesController : Controller
    
    {
         private readonly ILogger<ProfesController> _logger;
        public ProfesController(ILogger<ProfesController> logger)
        {
             _logger = logger;
        }
      

       public IActionResult ProfesAdd()
        {
            return View();  
        }  

         [HttpPost]
         public IActionResult ProfesAdd(ProfeModel profes)
        {
           if(!ModelState.IsValid)
           {
            _logger.LogWarning("El objeto no es valido");
            return View();
           }

            _logger.LogInformation("El objeto es valido");
         
            return Redirect("ListaProfesores");
        }  

           public IActionResult ListaProfesores()
    {
        /*seccion de listado de profes*/
         //_logger.LogInformation("Esto es un mensaje al cargar los profesores");
        
        //CREAR OBJETOS PROFES
        ProfeModel profe=new ProfeModel();
        profe.Nombre="Ricardo Elizalde";
        profe.Carrera="POO2";
        profe.Sexo="Masculino";
        

        ProfeModel profe2=new ProfeModel();
        profe2.Nombre="Pablo Chapa";
         profe2.Carrera="IDAE";
        profe2.Sexo="Masculino";
        

       

        ProfeModel profe3=new ProfeModel();
        profe3.Nombre="Javier Lara";
         profe3.Carrera="Cálculo integral".ToUpper();
        profe3.Sexo="Masculino";
        
        ProfeModel profe4=new ProfeModel();
        profe4.Nombre="Cesar Caballero";
         profe4.Carrera="Fundamentos de programación".ToUpper();
        profe4.Sexo="Masculino";

       //OBJETO DE LISTA DE PROFES
       List<ProfeModel>list=new List<ProfeModel>();    
        list.Add(profe);
        list.Add(profe2);
        list.Add(profe3);
        list.Add(profe4);

        

        return View(list);
    }

          public IActionResult ProfesSave()
        {
            /*
                Guardar info de profes
            */

            return Redirect("ListaProfesores");
        }   

        public IActionResult ProfeShowAndEdit(Guid Id)   
        {
            ProfeModel profe= new ProfeModel();
            profe.Id=Id;   
            profe.Nombre="Profesor cargado"; 
            return View(profe);  
        }

        public IActionResult ProfesEdit(Guid Id)
        {
             ProfeModel Docente=new ProfeModel();  
           Docente.Id=new Guid();
            Docente.Nombre="profe agregado";
            return View(Docente);
        }


             [HttpPost]
                 public IActionResult ProfesEdit(ProfeModel maestro)
        {
             if(!ModelState.IsValid)
           {
            _logger.LogWarning("El objeto no es valido");
            maestro.Nombre="Maestro no es valido";
            return View(maestro);
           }

            _logger.LogInformation("El objeto es valido");
         
            return Redirect("DegreeList");
           

           
        }




        public IActionResult ProfeShowToDelete(Guid Id)
        {

            //Con el id se buscara en la base de datos 
            //despues se le asignara al objeto
              ProfeModel profe= new ProfeModel();
            profe.Id=Id;   
            profe.Nombre="Profe para borrar"; 
            return View(profe); 
           
        }
         public IActionResult profesDeleted()
         {
            /*Borrar el registro*/

            return Redirect("ListaProfesores");
         }
       
    }
    
   

}