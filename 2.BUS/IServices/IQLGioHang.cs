using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLGioHang
    {
        bool Add(GioHang obj);
        bool Update(GioHang obj);
        bool Delete(GioHang obj);
        List<GioHang> GetGH();
        List<ViewGioHang> GetAll();
    }
}
