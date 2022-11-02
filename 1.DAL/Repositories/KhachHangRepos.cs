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
    public class KhachHangRepos : IKhachHangRepos
    {
        FpolyDBContext _dBContext;
        public KhachHangRepos()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(KhachHang obj)
        {
            if (obj == null) return false;
            _dBContext.KhachHangs.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.KhachHangs.FirstOrDefault(s => s.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return _dBContext.KhachHangs.ToList();
        }

        public KhachHang GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.KhachHangs.FirstOrDefault(s => s.Id == id);
        }

        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.KhachHangs.FirstOrDefault(s => s.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.TenDem = obj.TenDem;
            tempobj.Ho = obj.Ho;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt = obj.Sdt;
            tempobj.ThanhPho = obj.ThanhPho;
            tempobj.QuocGia = obj.QuocGia;
            tempobj.MatKhau = obj.MatKhau;
            _dBContext.KhachHangs.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
