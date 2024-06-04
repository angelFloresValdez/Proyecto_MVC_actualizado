using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProyectWithLineCommand.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
        }

        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
        
    }
}