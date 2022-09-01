using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IUuidEntityService
    {
        IResult Add(UuidEntity entity);
        IResult Update(UuidEntity entity);
        IResult Delete(Guid id);
        IDataResult<UuidEntity> GetById(Guid id);
        IDataResult<List<UuidEntity>> GetAll();
    }
}
