using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewHoaDon
    {
        public HoaDon hoadon { get; set; }
        public KhachHang khachHang { get; set; }
        public NhanVien nhanVien { get; set; }

    }
}
