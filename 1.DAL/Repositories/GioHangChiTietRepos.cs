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
    public class GioHangChiTietRepos : IGioHangChiTietRepos
    {
        FpolyDBContext _dBContext;
        public GioHangChiTietRepos()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(GioHangChiTiet obj)
        {
            if (obj == null) return false;
            _dBContext.GioHangChiTiets.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(GioHangChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.GioHangChiTiets.FirstOrDefault(s => s.IdGioHang == obj.IdGioHang);
            var a = _dBContext.GioHangChiTiets.FirstOrDefault(s => s.IdChiTietSp == obj.IdChiTietSp);
            _dBContext.RemoveRange(tempobj, a);
            _dBContext.SaveChanges();
            return true;
        }

        public List<GioHangChiTiet> GetAll()
        {
            return _dBContext.GioHangChiTiets.ToList();
        }

        public GioHangChiTiet GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.GioHangChiTiets.FirstOrDefault(s => s.IdGioHang == id);
        }

        public bool Update(GioHangChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.GioHangChiTiets.FirstOrDefault(s => s.IdGioHang == obj.IdGioHang);
            tempobj.SoLuong = obj.SoLuong;
            tempobj.DonGia = obj.DonGia;
            tempobj.DonGiaKhiGiam = obj.DonGiaKhiGiam;
            _dBContext.GioHangChiTiets.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
