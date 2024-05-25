using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProyectWithLineCommand.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public DateTime FechaCreacion {get; set;}    
    }
}