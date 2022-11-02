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
    public class QLGioHang : IQLGioHang
    {
        private IGioHangRepos _iGioHangRepos;
        private IKhachHangRepos _iKhachHangRepos;
        private INhanVienRepos _iNhanVienRepos;
        private List<ViewGioHang> _viewGioHangs;
        private List<GioHang> _lstGiohang;
        public QLGioHang()
        {
            _iGioHangRepos = new GioHangRepos();
            _iKhachHangRepos = new KhachHangRepos();
            _iNhanVienRepos = new NhanVienRepos();
            _viewGioHangs = new List<ViewGioHang>();
            _lstGiohang = new List<GioHang>();
        }
        public bool Add(GioHang obj)
        {
            _iGioHangRepos.Add(obj);
            return true;
        }

        public bool Delete(GioHang obj)
        {
            _iGioHangRepos.Delete(obj);
            return true;
        }

        public List<ViewGioHang> GetAll()
        {
            _viewGioHangs = (from a in _iGioHangRepos.GetAll()
                             join b in _iNhanVienRepos.GetAll() on a.IdNv equals b.Id
                             join c in _iKhachHangRepos.GetAll() on a.IdKh equals c.Id
                             select new ViewGioHang()
                             {
                                 gioHang = a,
                                 nhanVien = b,
                                 khachHang = c
                             }
                       ).ToList();
            return _viewGioHangs;
        }

        public List<GioHang> GetGH()
        {
            _lstGiohang = _iGioHangRepos.GetAll();
            return _lstGiohang;
        }

        public bool Update(GioHang obj)
        {
            _iGioHangRepos.Update(obj);
            return true;
        }
    }
}
