using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLDongSp
    {
        bool Add(ViewDongSP obj);
        bool Update(ViewDongSP obj);
        bool Delete(ViewDongSP obj);
        List<ViewDongSP> GetAll();
    }
}
