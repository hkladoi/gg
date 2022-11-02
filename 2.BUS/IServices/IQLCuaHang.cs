using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLCuaHang
    {
        string Add(ViewCuaHang obj);
        string Update(ViewCuaHang obj);
        string Delete(ViewCuaHang obj);
        CuaHang GetByID(Guid id);
        List<ViewCuaHang> GetAll();
    }
}
