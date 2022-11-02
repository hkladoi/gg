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
    public class QLHoaDonChiTiet : IQLHoaDonChiTiet
    {
        private IHoaDonChiTietRepos _iQLHoaDonChiTiet;
        private IHoaDonRepos _iQLHoaDon;
        private IChiTietSPRepos _iChiTietSpRepos;
        private INsxRepos _iNsxRepos;
        private IDongSpRepos _iDongSpRepo;
        private IMauSacRepos _iMauSacRepos;
        private ISanPhamRepos _iSanPhamRepos;
        private List<HoaDonChiTiet> _lstHoaDonCT;
        private List<ViewHoaDonChiTiet> _lstViewHoaDonCT;
        public QLHoaDonChiTiet()
        {
            _iQLHoaDonChiTiet = new HoaDonChiTietRepos();
            _iQLHoaDon = new HoaDonRepos();
            _lstHoaDonCT = new List<HoaDonChiTiet>();
            _lstViewHoaDonCT = new List<ViewHoaDonChiTiet>();
            _iChiTietSpRepos = new ChiTietSPRepos();
            _iSanPhamRepos = new SanPhamRepos();
            _iMauSacRepos = new MauSacRepos();
            _iDongSpRepo = new DongSpRepos();
            _iNsxRepos = new NsxRepos();
        }
        public bool Add(HoaDonChiTiet obj)
        {
            _iQLHoaDonChiTiet.Add(obj);
            return true;
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            _iQLHoaDonChiTiet.Delete(obj);
            return true;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            _lstHoaDonCT = _iQLHoaDonChiTiet.GetAll();
            return _lstHoaDonCT;
        }

        public List<ViewHoaDonChiTiet> GetAllHD()
        {
            _lstViewHoaDonCT = (from a in _iQLHoaDonChiTiet.GetAll()
                                join b in _iQLHoaDon.GetAll() on a.IdHoaDon equals b.Id
                                join c in _iChiTietSpRepos.GetAll() on a.IdChiTietSp equals c.Id
                                join d in _iSanPhamRepos.GetAll() on c.IdSp equals d.Id
                                select new ViewHoaDonChiTiet()
                                {
                                    hoaDonChiTiet = a,
                                    hoaDon = b,
                                    chiTietSp = c,
                                    TenSp = d.Ten,
                                    MaSp = d.Ma

                                }).ToList();
            return _lstViewHoaDonCT;
        }

        public bool Update(HoaDonChiTiet obj)
        {
            _iQLHoaDonChiTiet.Update(obj);
            return true;
        }
    }
}
