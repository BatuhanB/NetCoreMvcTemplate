using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUuidEntityService
    {
        void Add(UuidEntity entity);
        void Update(UuidEntity entity);
        void Delete(UuidEntity entity);
        void GetById(Guid id);
        List<UuidEntity> GetAll();
    }
}
