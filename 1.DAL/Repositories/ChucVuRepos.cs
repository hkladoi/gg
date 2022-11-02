using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ChucVuRepos : IChucVuRepos
    {
        FpolyDBContext _dBContext;
        public ChucVuRepos()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            _dBContext.ChucVus.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.ChucVus.FirstOrDefault(s => s.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _dBContext.ChucVus.ToList();
        }

        public ChucVu GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.ChucVus.FirstOrDefault(s => s.Id == id);
        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.ChucVus.FirstOrDefault(s => s.Id == obj.Id);
            tempobj.Ten = obj.Ten;
            tempobj.Ma = obj.Ma;
            _dBContext.ChucVus.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
