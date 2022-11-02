using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLChiTietSP
    {
        bool Add(ViewChiTietSP obj);
        bool Update(ViewChiTietSP obj);
        bool Delete(ViewChiTietSP obj);
        List<ViewChiTietSP> GetAllSP();
    }
}
