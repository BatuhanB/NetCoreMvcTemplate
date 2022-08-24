using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Abstract
{
    public abstract class BaseEntity:IEntity
    {
        [Key]
        public int Id { get; set; }

        public BaseEntity()
        {

        }

        public BaseEntity(int id):this()
        {
            Id = id;
        }
    }
}
