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
        void Add(SampleEntity entity);
        void Update(SampleEntity entity);
        void Delete(SampleEntity entity);
        void GetById(int id);
        List<SampleEntity> GetAll();

    }
}
