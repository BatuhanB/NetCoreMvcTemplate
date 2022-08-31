using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Concrete;

namespace Business.Abstract
{
    public interface IUuidEntityService
    {
        Result Add(UuidEntity entity);
        Result Update(UuidEntity entity);
        Result Delete(int id);
        DataResult<UuidEntity> GetById(Guid id);
        DataResult<List<UuidEntity>> GetAll();
    }
}
