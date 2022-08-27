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
    public class UuidEntityManager : IUuidEntityService
    {
        private readonly IUuidEntityDal _entityDal;

        public UuidEntityManager(IUuidEntityDal entityDal)
        {
            _entityDal = entityDal;
        }

        public void Add(UuidEntity entity)
        {
            _entityDal.Add(entity);
        }

        public void Delete(UuidEntity entity)
        {
            _entityDal.Delete(entity);
        }

        public List<UuidEntity> GetAll()
        {
            return _entityDal.GetAll();
        }

        public void GetById(Guid id)
        {
           _entityDal.GetById(x=>x.Id == id);
        }

        public void Update(UuidEntity entity)
        {
            _entityDal.Update(entity);
        }
    }
}
