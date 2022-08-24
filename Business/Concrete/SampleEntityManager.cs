using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SampleEntityManager : ISampleEntityService
    {
        private readonly IEntityDal _entityDal;

        public SampleEntityManager(IEntityDal entityDal)
        {
            _entityDal = entityDal;
        }

        public void Add(SampleEntity entity)
        {
             _entityDal.Add(entity);  
        }

        public void Delete(SampleEntity entity)
        {
           _entityDal?.Delete(entity);
        }

        public List<SampleEntity> GetAll()
        {       
            return _entityDal.GetAll();
        }

        public void GetById(int id)
        {
            _entityDal.GetById(x=>x.Id == id);
        }

        public void Update(SampleEntity entity)
        {
            _entityDal.Update(entity);
        }
    }
}
