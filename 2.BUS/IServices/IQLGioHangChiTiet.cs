using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLGioHangChiTiet
    {
        bool Add(GioHangChiTiet obj);
        bool Update(GioHangChiTiet obj);
        bool Delete(GioHangChiTiet obj);
        List<ViewGioHangCT> GetAllGH();
        List<GioHangChiTiet> GetAll();
    }
}
