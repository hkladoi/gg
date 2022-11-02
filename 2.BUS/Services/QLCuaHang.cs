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
    public class QLCuaHang : IQLCuaHang
    {
        private ICuaHangRepos _iCuaHangRepos;
        public QLCuaHang()
        {
            _iCuaHangRepos = new CuaHangRepos();
        }
        public string Add(ViewCuaHang obj)
        {
            var ch = new CuaHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
            };
            _iCuaHangRepos.Add(ch);
            return "thành công";
        }

        public string Delete(ViewCuaHang obj)
        {
            var ch = new CuaHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
            };
            _iCuaHangRepos.Delete(ch);
            return "thành công";
        }

        public List<ViewCuaHang> GetAll()
        {
            List<ViewCuaHang> _lstCuaHang = new List<ViewCuaHang>();
            _lstCuaHang = (
                from a in _iCuaHangRepos.GetAll()
                select new ViewCuaHang()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                    DiaChi = a.DiaChi,
                    ThanhPho = a.ThanhPho,
                    QuocGia = a.QuocGia,
                }).ToList();
            return _lstCuaHang;
        }

        public CuaHang GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(ViewCuaHang obj)
        {
            var ch = new CuaHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
            };
            _iCuaHangRepos.Update(ch);
            return "thành công";
        }
    }
}
