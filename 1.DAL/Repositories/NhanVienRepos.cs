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
    public class NhanVienRepos : INhanVienRepos
    {
        FpolyDBContext _dBContext;
        public NhanVienRepos()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            _dBContext.NhanViens.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.NhanViens.FirstOrDefault(x => x.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _dBContext.NhanViens.ToList();
        }

        public NhanVien GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.NhanViens.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.NhanViens.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.TenDem = obj.TenDem;
            tempobj.Ho = obj.Ho;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt = obj.Sdt;
            tempobj.MatKhau = obj.MatKhau;
            tempobj.TrangThai = obj.TrangThai;
            _dBContext.NhanViens.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
