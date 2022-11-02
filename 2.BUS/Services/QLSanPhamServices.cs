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
    public class QLSanPhamServices : IQLSanPhamServices
    {
        private ISanPhamRepos _iSanPhamRepos;

        public QLSanPhamServices()
        {
            _iSanPhamRepos = new SanPhamRepos();
        }

        public bool Add(ViewSanPham obj)
        {
            var vsp = new SanPham()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            _iSanPhamRepos.Add(vsp);
            return true;
        }

        public bool Delete(ViewSanPham obj)
        {
            var vsp = new SanPham()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            _iSanPhamRepos.Delete(vsp);
            return true;
        }

        public List<ViewSanPham> GetAll()
        {
            List<ViewSanPham> _lstSanPham = new List<ViewSanPham>();
            _lstSanPham = (
                from a in _iSanPhamRepos.GetAll()
                select new ViewSanPham()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                }).ToList();
            return _lstSanPham;
        }

        public bool Update(ViewSanPham obj)
        {
            var vsp = new SanPham()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            _iSanPhamRepos.Update(vsp);
            return true;
        }
    }
}
