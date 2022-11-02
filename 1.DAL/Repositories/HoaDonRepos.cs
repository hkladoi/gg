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
    public class HoaDonRepos : IHoaDonRepos
    {
        FpolyDBContext _dBContext;
        public HoaDonRepos()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(HoaDon obj)
        {
            if (obj == null) return false;
            _dBContext.HoaDons.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.HoaDons.FirstOrDefault(s => s.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _dBContext.HoaDons.ToList();
        }

        public HoaDon GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.HoaDons.FirstOrDefault(s => s.Id == id);
        }

        public bool Update(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.HoaDons.FirstOrDefault(s => s.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.NgayTao = obj.NgayTao;
            tempobj.NgayThanhToan = obj.NgayThanhToan;
            tempobj.NgayShip = obj.NgayShip;
            tempobj.NgayNhan = obj.NgayNhan;
            tempobj.TenNguoiNhan = obj.TenNguoiNhan;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt = obj.Sdt;
            tempobj.TinhTrang = obj.TinhTrang;
            _dBContext.HoaDons.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
