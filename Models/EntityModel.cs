using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProyectWithLineCommand.Models
{
    public class EntityModel 
    {
        public EntityModel()
        {
        }
        

        public Guid Id { get; set; }
        public int matricula   { get; set; } 
        public string Nombre {get; set; }
        public string Carrera {get; set;}
        public int Edad {get; set;}
        public string Sexo {get; set;} 

        public DateTime Fechacreacion {get; set;}   
    }
}