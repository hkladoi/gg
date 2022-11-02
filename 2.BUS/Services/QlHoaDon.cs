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
    public class QlHoaDon : IQLHoaDon
    {
        private IHoaDonRepos _iHoaDonRepos;
        private IKhachHangRepos _iKhachHangRepos;
        private INhanVienRepos _inhanVienRepos;
        private List<HoaDon> _lstHoaDon;
        private List<ViewHoaDon> _lstViewHoaDon;
        public QlHoaDon()
        {
            _iHoaDonRepos = new HoaDonRepos();
            _iKhachHangRepos = new KhachHangRepos();
            _inhanVienRepos = new NhanVienRepos();
            _lstHoaDon = new List<HoaDon>();
            _lstViewHoaDon = new List<ViewHoaDon>();
        }

        public bool Add(HoaDon obj)
        {
            _iHoaDonRepos.Add(obj);
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            _iHoaDonRepos.Delete(obj);
            return true;
        }

        public List<HoaDon> GetAll()
        {
            _lstHoaDon = _iHoaDonRepos.GetAll();
            return _lstHoaDon;
        }

        public List<ViewHoaDon> GetAllHoaDon()
        {
            _lstViewHoaDon = (from hd in GetAll()
                              join kh in _iKhachHangRepos.GetAll() on hd.IdKh equals kh.Id
                              join nv in _inhanVienRepos.GetAll() on hd.IdNv equals nv.Id
                              select new ViewHoaDon
                              {
                                  hoadon = hd,
                                  khachHang = kh,
                                  nhanVien = nv,
                              }).ToList();
            return _lstViewHoaDon;
        }

        public bool Update(HoaDon obj)
        {
            _iHoaDonRepos.Update(obj);
            return true;
        }
    }
}
