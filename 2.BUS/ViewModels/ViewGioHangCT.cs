using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewGioHangCT
    {
        public GioHangChiTiet gioHangChiTiet { get; set; }
        public ChiTietSp chiTietSp { get; set; }
        public GioHang gioHang { get; set; }
        public string TenSp { get; set; }
        public string MaSp { get; set; }
        public string Nsx { get; set; }
        public string mauSac { get; set; }
        public string DongSp { get; set; }
        //    if (tb_tensp.Text != "")
        //        {
        //            _lstCTSanpham = _lstCTSanpham.Where(p=> p.TenSP.Contains(tb_tensp.Text)).ToList();
        //}
        //        if(tb_gia1.Text != "" && tb_gia2.Text != "")
        //        {
        //            _lstCTSanpham = _lstCTSanpham.Where(p => p.GiaBan <= Convert.ToDecimal(tb_gia2.Text) && p.GiaBan >= Convert.ToDecimal(tb_gia1.Text)).ToList();
        //} 
    }
}
