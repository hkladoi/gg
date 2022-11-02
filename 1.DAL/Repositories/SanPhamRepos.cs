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
    public class SanPhamRepos : ISanPhamRepos
    {
        FpolyDBContext _dBContext;
        public SanPhamRepos()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(SanPham obj)
        {
            if (obj == null) return false;
            _dBContext.SanPhams.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(SanPham obj)
        {
            if (obj == null) return false;
            var temobj = _dBContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);
            _dBContext.Remove(temobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
            return _dBContext.SanPhams.ToList();
        }

        public SanPham GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.SanPhams.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(SanPham obj)
        {
            if (obj == null) return false;
            var temobj = _dBContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);
            temobj.Ten = obj.Ten;
            temobj.Ma = obj.Ma;
            _dBContext.SanPhams.Update(temobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
