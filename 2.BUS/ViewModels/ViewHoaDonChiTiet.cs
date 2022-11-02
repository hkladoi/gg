using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewHoaDonChiTiet
    {
        internal readonly object IdChiTietSp;

        public HoaDonChiTiet hoaDonChiTiet { get; set; }
        public ChiTietSp chiTietSp { get; set; }
        public HoaDon hoaDon { get; set; }
        public string TenSp { get; set; }
        public string MaSp { get; set; }
    }
}
