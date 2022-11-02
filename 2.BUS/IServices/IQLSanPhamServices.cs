using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IQLSanPhamServices
    {
        bool Add(ViewSanPham obj);
        bool Update(ViewSanPham obj);
        bool Delete(ViewSanPham obj);
        List<ViewSanPham> GetAll();
    }
}
