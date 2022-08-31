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
        Result Add(SampleEntity entity);
        Result Update(SampleEntity entity);
        Result Delete(int id);
        DataResult<SampleEntity> GetById(int id);
        DataResult<List<SampleEntity>> GetAll();

    }
}
