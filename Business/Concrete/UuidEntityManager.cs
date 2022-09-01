using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Results.Abstract;

namespace Business.Concrete
{
    public class UuidEntityManager : IUuidEntityService
    {
        private readonly IUuidEntityDal _entityDal;

        public UuidEntityManager(IUuidEntityDal entityDal)
        {
            _entityDal = entityDal;
        }


        public IResult Add(UuidEntity entity)
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

        public IResult Update(UuidEntity entity)
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

        public IResult Delete(Guid id)
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

        public IDataResult<UuidEntity> GetById(Guid id)
        {
            try
            {
                return new SuccessDataResult<UuidEntity>(_entityDal.GetById(x=>x.Id == id));
            }
            catch (Exception)
            {
                return new ErrorDataResult<UuidEntity>();
            }
        }

        public IDataResult<List<UuidEntity>> GetAll()
        {
            try
            {
                return new SuccessDataResult<List<UuidEntity>>(_entityDal.GetAll());
            }
            catch (Exception)
            {
                return new ErrorDataResult<List<UuidEntity>>();
            }
        }
    }
}
