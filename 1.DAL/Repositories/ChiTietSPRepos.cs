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
    public class ChiTietSPRepos : IChiTietSPRepos
    {
        FpolyDBContext _dBContext;
        public ChiTietSPRepos()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(ChiTietSp obj)
        {
            if (obj == null) return false;
            _dBContext.ChiTietSps.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.ChiTietSps.FirstOrDefault(s => s.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<ChiTietSp> GetAll()
        {
            return _dBContext.ChiTietSps.ToList();
        }

        public ChiTietSp GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.ChiTietSps.FirstOrDefault(s => s.Id == id);
        }

        public bool Update(ChiTietSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.ChiTietSps.FirstOrDefault(s => s.Id == obj.Id);
            tempobj.GiaBan = obj.GiaBan;
            tempobj.GiaNhap = obj.GiaNhap;
            tempobj.IdDongSp = obj.IdDongSp;
            tempobj.IdMauSac = obj.IdMauSac;
            tempobj.IdNsx = obj.IdNsx;
            tempobj.IdSp = obj.IdSp;
            tempobj.SoLuongTon = obj.SoLuongTon;
            tempobj.MoTa = obj.MoTa;
            tempobj.NamBh = obj.NamBh;
            _dBContext.ChiTietSps.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
