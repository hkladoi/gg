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
    public class QLGioHangChiTiet : IQLGioHangChiTiet
    {
        private IGioHangChiTietRepos _iQLGioHangChiTiet;
        private IGioHangRepos _iQLGioHang;
        private IChiTietSPRepos _iChiTietSpRepos;
        private INsxRepos _iNsxRepos;
        private IDongSpRepos _iDongSpRepo;
        private IMauSacRepos _iMauSacRepos;
        private ISanPhamRepos _iSanPhamRepos;
        private List<GioHangChiTiet> _lstGioHangCt;
        private List<ViewGioHangCT> _lstViewGioHangCT;
        public QLGioHangChiTiet()
        {
            _iQLGioHangChiTiet = new GioHangChiTietRepos();
            _iQLGioHang = new GioHangRepos();
            _lstGioHangCt = new List<GioHangChiTiet>();
            _lstViewGioHangCT = new List<ViewGioHangCT>();
            _iChiTietSpRepos = new ChiTietSPRepos();
            _iSanPhamRepos = new SanPhamRepos();
            _iMauSacRepos = new MauSacRepos();
            _iDongSpRepo = new DongSpRepos();
            _iNsxRepos = new NsxRepos();
        }
        public bool Add(GioHangChiTiet obj)
        {
            _iQLGioHangChiTiet.Add(obj);
            return true;
        }

        public bool Delete(GioHangChiTiet obj)
        {
            _iQLGioHangChiTiet.Delete(obj);
            return true;
        }

        public List<GioHangChiTiet> GetAll()
        {
            _lstGioHangCt = _iQLGioHangChiTiet.GetAll();
            return _lstGioHangCt;
        }

        public List<ViewGioHangCT> GetAllGH()
        {
            _lstViewGioHangCT = (from a in _iQLGioHangChiTiet.GetAll()
                                 join b in _iQLGioHang.GetAll() on a.IdGioHang equals b.Id
                                 join c in _iChiTietSpRepos.GetAll() on a.IdChiTietSp equals c.Id
                                 join d in _iSanPhamRepos.GetAll() on c.IdSp equals d.Id
                                 join e in _iNsxRepos.GetAll() on c.IdNsx equals e.Id
                                 join f in _iMauSacRepos.GetAll() on c.IdMauSac equals f.Id
                                 join g in _iDongSpRepo.GetAll() on c.IdDongSp equals g.Id
                                 select new ViewGioHangCT()
                                 {
                                     gioHangChiTiet = a,
                                     gioHang = b,
                                     chiTietSp = c,
                                     TenSp = d.Ten,
                                     MaSp = d.Ma,
                                     Nsx = e.Ten,
                                     mauSac = f.Ten,
                                     DongSp = g.Ten,
                                 }).ToList();
            return _lstViewGioHangCT;
        }

        public bool Update(GioHangChiTiet obj)
        {
            _iQLGioHangChiTiet.Update(obj);
            return true;
        }
    }
}
