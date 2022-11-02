using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class QLChiTietSP : IQLChiTietSP
    {
        private IChiTietSPRepos _iChiTietSpRepos;
        private INsxRepos _iNsxRepos;
        private IDongSpRepos _iDongSpRepo;
        private IMauSacRepos _iMauSacRepos;
        private ISanPhamRepos _iSanPhamRepos;
        List<ChiTietSp> _lstChiTietSp;
        List<ViewChiTietSP> _lstViewSP;
        public QLChiTietSP()
        {
            _iChiTietSpRepos = new ChiTietSPRepos();
            _lstViewSP = new List<ViewChiTietSP>();
            _lstChiTietSp = new List<ChiTietSp>();
            _iSanPhamRepos = new SanPhamRepos();
            _iMauSacRepos = new MauSacRepos();
            _iDongSpRepo = new DongSpRepos();
            _iNsxRepos = new NsxRepos();
        }

        public bool Add(ViewChiTietSP obj)
        {
            var vct = new ChiTietSp()
            {
                Id = obj.Id,
                IdSp = obj.IdSP,
                MoTa = obj.MoTa,
                SoLuongTon = obj.SoLuongTon,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
            };
            _iChiTietSpRepos.Add(vct);
            return true;
        }

        public bool Delete(ViewChiTietSP obj)
        {
            var vct = new ChiTietSp()
            {
                Id = obj.Id,
                IdSp = obj.IdSP,
                MoTa = obj.MoTa,
                SoLuongTon = obj.SoLuongTon,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
            };
            _iChiTietSpRepos.Delete(vct);
            return true;
        }

        public List<ChiTietSp> GetAll()
        {
            _lstChiTietSp = _iChiTietSpRepos.GetAll();
            return _lstChiTietSp;
        }

        public List<ViewChiTietSP> GetAllSP()
        {
            List<ViewChiTietSP> _lstViewSP = new List<ViewChiTietSP>();
            _lstViewSP = (from ct in _iChiTietSpRepos.GetAll()
                          join sp in _iSanPhamRepos.GetAll() on ct.IdSp equals sp.Id
                          select new ViewChiTietSP
                          {
                              Id = ct.Id,
                              IdSP = sp.Id,
                              MoTa = ct.MoTa,
                              SoLuongTon = ct.SoLuongTon,
                              GiaNhap = ct.GiaNhap,
                              GiaBan = ct.GiaBan,
                              total = Convert.ToInt32(ct.SoLuongTon * ct.GiaNhap),
                          }).ToList();
            return _lstViewSP;
        }

        public bool Update(ViewChiTietSP obj)
        {
            var vct = new ChiTietSp()
            {
                Id = obj.Id,
                IdSp = obj.IdSP,
                MoTa = obj.MoTa,
                SoLuongTon = obj.SoLuongTon,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
            };
            _iChiTietSpRepos.Update(vct);
            return true;
        }
    }
}
