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
    public class HoaDonChiTietRepos : IHoaDonChiTietRepos
    {
        FpolyDBContext _dBContext;
        public HoaDonChiTietRepos()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            _dBContext.HoaDonChiTiets.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.HoaDonChiTiets.FirstOrDefault(s => s.IdHoaDon == obj.IdHoaDon);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _dBContext.HoaDonChiTiets.ToList();
        }

        public HoaDonChiTiet GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.HoaDonChiTiets.FirstOrDefault(s => s.IdHoaDon == id);
        }

        public bool Update(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.HoaDonChiTiets.FirstOrDefault(s => s.IdHoaDon == obj.IdHoaDon);
            tempobj.SoLuong = obj.SoLuong;
            tempobj.DonGia = obj.DonGia;
            _dBContext.HoaDonChiTiets.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
