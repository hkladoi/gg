using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLNhanVien : IQLNhanVien
    {
        private INhanVienRepos _iNhanVienRepos;
        private ICuaHangRepos _icuaHangRepos;
        private IChucVuRepos _ichucVuServices;
        private List<NhanVien> _lstNhanVien;
        private List<ViewNhanVien> _lstViewNhanVien;
        public QLNhanVien()
        {
            _iNhanVienRepos = new NhanVienRepos();
            _icuaHangRepos = new CuaHangRepos();
            _ichucVuServices = new ChucVuRepos();
            _lstNhanVien = new List<NhanVien>();
        }

        public bool Add(ViewNhanVien obj)
        {
            var vnv = new NhanVien()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                MatKhau = obj.MatKhau,
                IdCh = obj.IdCh,
                IdCv = obj.IdCv,
                IdGuiBc = obj.IdGuiBc,
                TrangThai = obj.TrangThai,
            };
            _iNhanVienRepos.Add(vnv);
            return true;
        }

        public bool Delete(ViewNhanVien obj)
        {
            var vnv = new NhanVien()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                MatKhau = obj.MatKhau,
                IdCh = obj.IdCh,
                IdCv = obj.IdCv,
                IdGuiBc = obj.IdGuiBc,
                TrangThai = obj.TrangThai,
            };
            _iNhanVienRepos.Delete(vnv);
            return true;
        }

        public List<ViewNhanVien> GetViewNVs()
        {
            _lstViewNhanVien = (from nv in _iNhanVienRepos.GetAll()
                                join ch in _icuaHangRepos.GetAll() on nv.IdCh equals ch.Id
                                join cv in _ichucVuServices.GetAll() on nv.IdCv equals cv.Id
                                select new ViewNhanVien
                                {
                                    Id = nv.Id,
                                    Ma = nv.Ma,
                                    Ten = nv.Ten,
                                    TenDem = nv.TenDem,
                                    Ho = nv.Ho,
                                    GioiTinh = nv.GioiTinh,
                                    NgaySinh = nv.NgaySinh,
                                    DiaChi = nv.DiaChi,
                                    Sdt = nv.Sdt,
                                    MatKhau = nv.MatKhau,
                                    IdCh = ch.Id,
                                    IdCv = cv.Id,
                                    IdGuiBc = nv.IdGuiBc,
                                    TrangThai = nv.TrangThai,
                                }).ToList();
            return _lstViewNhanVien;
        }

        public bool Update(ViewNhanVien obj)
        {
            var vnv = new NhanVien()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                MatKhau = obj.MatKhau,
                IdCh = obj.IdCh,
                IdCv = obj.IdCv,
                IdGuiBc = obj.IdGuiBc,
                TrangThai = obj.TrangThai,
            };
            _iNhanVienRepos.Update(vnv);
            return true;
        }
    }
}
