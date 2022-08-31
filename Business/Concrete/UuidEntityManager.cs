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
    public class UuidEntityManager : IUuidEntityService
    {
        private readonly IUuidEntityDal _entityDal;

        public UuidEntityManager(IUuidEntityDal entityDal)
        {
            _entityDal = entityDal;
        }


        public Result Add(UuidEntity entity)
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

        public Result Update(UuidEntity entity)
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

        public Result Delete(Guid id)
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

        public DataResult<UuidEntity> GetById(Guid id)
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

        public DataResult<List<UuidEntity>> GetAll()
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
