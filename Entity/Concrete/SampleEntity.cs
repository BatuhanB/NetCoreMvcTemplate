using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class SampleEntity:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }

        public SampleEntity()
        {

        }

        public SampleEntity(int id, string name, string description, bool status, DateTime createDate) : base()
        {
            Id = id;
            Name = name;
            Description = description;
            Status = status;
            CreateDate = createDate;
        }
    }
}
