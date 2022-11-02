using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class QLKhachHang : IQLKhachHang
    {
        private IKhachHangRepos _iKhachHangRepos;
        public QLKhachHang()
        {
            _iKhachHangRepos = new KhachHangRepos();
        }
        public bool Add(ViewKhachHang obj)
        {
            var vkh = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                NgaySinh = obj.NgaySinh,
                //Sdt = obj.Sdt,
                DiaChi = obj.DiaChi,
                //ThanhPho = obj.ThanhPho,
                //QuocGia = obj.QuocGia,
                //MatKhau = obj.MatKhau,
            };
            _iKhachHangRepos.Add(vkh);
            return true;
        }

        public bool Delete(ViewKhachHang obj)
        {
            var vkh = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                NgaySinh = obj.NgaySinh,
                //Sdt = obj.Sdt,
                DiaChi = obj.DiaChi,
                //ThanhPho = obj.ThanhPho,
                //QuocGia = obj.QuocGia,
                //MatKhau = obj.MatKhau,
            };
            _iKhachHangRepos.Delete(vkh);
            return true;
        }

        public List<ViewKhachHang> GetAll()
        {
            List<ViewKhachHang> _lstKhachHang = new List<ViewKhachHang>();
            _lstKhachHang = (
                from a in _iKhachHangRepos.GetAll()
                select new ViewKhachHang()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                    TenDem = a.TenDem,
                    Ho = a.Ho,
                    TenDayDu = String.Concat(a.TenDem, " ", a.Ten, " ", a.Ho),
                    NgaySinh = a.NgaySinh,
                    //Sdt = a.Sdt,
                    DiaChi = a.DiaChi,
                    //ThanhPho = a.ThanhPho,
                    //QuocGia = a.QuocGia,
                    //MatKhau = a.MatKhau,
                }).ToList();
            return _lstKhachHang;
        }

        public bool Update(ViewKhachHang obj)
        {
            var vkh = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                NgaySinh = obj.NgaySinh,
                //Sdt = obj.Sdt,
                DiaChi = obj.DiaChi,
                //ThanhPho = obj.ThanhPho,
                //QuocGia = obj.QuocGia,
                //MatKhau = obj.MatKhau,
            };
            _iKhachHangRepos.Update(vkh);
            return true;
        }
    }
}
