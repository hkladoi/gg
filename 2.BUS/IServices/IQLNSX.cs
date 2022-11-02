using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLNSX
    {
        bool Add(ViewNSX obj);
        bool Update(ViewNSX obj);
        bool Delete(ViewNSX obj);
        List<ViewNSX> GetAll();
    }
}
