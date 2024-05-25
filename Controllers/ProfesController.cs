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
      
    public  ProfesController()
    {
        
        
    }
       public IActionResult ProfesAdd()
        {
            return View();  
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

        public IActionResult ProfesEdit()
        {
            /*
                Editar info de profes
            */

            return Redirect("ListaProfesores");
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