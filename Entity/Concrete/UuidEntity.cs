using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class UuidEntity:IEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }

        public UuidEntity()
        {
            
        }

        public UuidEntity(Guid id, string name, string description, bool status, DateTime createDate)
        {
            Id = id;
            Name = name;
            Description = description;
            Status = status;
            CreateDate = createDate;
        }
    }
}
