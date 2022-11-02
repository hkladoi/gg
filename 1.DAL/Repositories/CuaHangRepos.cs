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
    public class CuaHangRepos : ICuaHangRepos
    {
        FpolyDBContext _dBContext;
        public CuaHangRepos()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(CuaHang obj)
        {
            if (obj == null) return false;
            _dBContext.CuaHangs.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(CuaHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.CuaHangs.FirstOrDefault(s => s.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<CuaHang> GetAll()
        {
            return _dBContext.CuaHangs.ToList();
        }

        public CuaHang GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.CuaHangs.FirstOrDefault(s => s.Id == id);
        }

        public bool Update(CuaHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.CuaHangs.FirstOrDefault(s => s.Id == obj.Id);
            tempobj.Ten = obj.Ten;
            tempobj.Ma = obj.Ma;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.ThanhPho = obj.ThanhPho;
            tempobj.QuocGia = obj.QuocGia;
            _dBContext.CuaHangs.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
