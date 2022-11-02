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
    public class GioHangRepos : IGioHangRepos
    {
        FpolyDBContext _dBContext;
        public GioHangRepos()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(GioHang obj)
        {
            if (obj == null) return false;
            _dBContext.GioHangs.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(GioHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.GioHangs.FirstOrDefault(s => s.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<GioHang> GetAll()
        {
            return _dBContext.GioHangs.ToList();
        }

        public GioHang GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.GioHangs.FirstOrDefault(s => s.Id == id);
        }

        public bool Update(GioHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.GioHangs.FirstOrDefault(s => s.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.NgayTao = obj.NgayTao;
            tempobj.NgayThanhToan = obj.NgayThanhToan;
            tempobj.TenNguoiNhan = obj.TenNguoiNhan;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt = obj.Sdt;
            tempobj.TinhTrang = obj.TinhTrang;
            _dBContext.GioHangs.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
