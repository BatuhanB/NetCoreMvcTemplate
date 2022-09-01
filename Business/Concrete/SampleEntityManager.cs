using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Constants;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Results.Abstract;

namespace Business.Concrete
{
    public class SampleEntityManager : ISampleEntityService
    {
        private readonly IEntityDal _entityDal;

        public SampleEntityManager(IEntityDal entityDal)
        {
            _entityDal = entityDal;
        }


        public IResult Add(SampleEntity entity)
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

        public IResult Update(SampleEntity entity)
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

        public IResult Delete(int id)
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

        public IDataResult<SampleEntity> GetById(int id)
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

        public IDataResult<List<SampleEntity>> GetAll()
        {
            try
            {
                return new SuccessDataResult<List<SampleEntity>>(Messages.SuccessDataListed,_entityDal.GetAll());
            }
            catch (Exception)
            {
                return new ErrorDataResult<List<SampleEntity>>(Messages.ErrorDataListed);
            }
        }

        public IResult ChangeStatus(int id)
        {
            try
            {
                var result = _entityDal.GetById(x=>x.Id == id);
                if (result == null) return new ErrorResult();
                if (result.Status == false)
                {
                    result.Status = true;
                }
                else if (result.Status)
                {
                    result.Status = false;
                }
                _entityDal.Update(result);
                return new SuccessResult();

            }
            catch (Exception )
            {
                return new ErrorResult();
            }
        }
    }
}
