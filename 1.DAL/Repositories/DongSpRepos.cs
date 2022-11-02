using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class DongSpRepos : IDongSpRepos
    {
        FpolyDBContext _dBContext;
        public DongSpRepos()
        {
            _dBContext = new FpolyDBContext();
        }

        public bool Add(DongSp obj)
        {
            if (obj == null) return false;
            _dBContext.DongSps.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(DongSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.DongSps.FirstOrDefault(s => s.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<DongSp> GetAll()
        {
            return _dBContext.DongSps.ToList();
        }

        public DongSp GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.DongSps.FirstOrDefault(s => s.Id == id);
        }

        public bool Update(DongSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.DongSps.FirstOrDefault(s => s.Id == obj.Id);
            tempobj.Ten = obj.Ten;
            tempobj.Ma = obj.Ma;
            _dBContext.DongSps.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
