using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace _2.BUS.ViewModels
{
    public class ViewChiTietSP
    {

        public Guid Id { get; set; }
        public Guid IdSP { get; set; }
        public string MoTa { get; set; }
        public int? SoLuongTon { get; set; }
        public decimal? GiaNhap { get; set; }
        public decimal? GiaBan { get; set; }
        public int total { get; set; }
    }
}
