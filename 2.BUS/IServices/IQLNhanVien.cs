using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLNhanVien
    {
        bool Add(ViewNhanVien obj);
        bool Update(ViewNhanVien obj);
        bool Delete(ViewNhanVien obj);
        List<ViewNhanVien> GetViewNVs();
    }
}
