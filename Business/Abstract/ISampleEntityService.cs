using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISampleEntityService
    {
        IResult Add(SampleEntity entity);
        IResult Update(SampleEntity entity);
        IResult Delete(int id);
        IDataResult<SampleEntity> GetById(int id);
        IDataResult<List<SampleEntity>> GetAll();
        IResult ChangeStatus(int id);
    }
}
