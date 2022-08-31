using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Concrete;

namespace Business.Concrete
{
    public class SampleEntityManager : ISampleEntityService
    {
        private readonly IEntityDal _entityDal;

        public SampleEntityManager(IEntityDal entityDal)
        {
            _entityDal = entityDal;
        }


        public Result Add(SampleEntity entity)
        {
            try
            {
                _entityDal.Add(entity);
                return new SuccessResult(); 
            }
            catch (Exception)
            {
                return new ErrorResult();
            }
            
        }

        public Result Update(SampleEntity entity)
        {
            try
            {
                _entityDal.Update(entity);
                return new SuccessResult();
            }
            catch (Exception)
            {
                return new ErrorResult();
            }
        }

        public Result Delete(int id)
        {
            try
            {
                var result = _entityDal.GetAll().FirstOrDefault(x => x.Id == id);
                _entityDal.Delete(result);
                return new SuccessResult();
            }
            catch (Exception)
            {
                return new ErrorResult();
            }
        }

        public DataResult<SampleEntity> GetById(int id)
        {
            try
            {
                return new SuccessDataResult<SampleEntity>(_entityDal.GetById(x=>x.Id == id));
            }
            catch (Exception)
            {
                return new ErrorDataResult<SampleEntity>();
            }
        }

        public DataResult<List<SampleEntity>> GetAll()
        {
            try
            {
                return new SuccessDataResult<List<SampleEntity>>("Data has been successfully listed.",_entityDal.GetAll());
            }
            catch (Exception)
            {
                return new ErrorDataResult<List<SampleEntity>>();
            }
        }
    }
}
