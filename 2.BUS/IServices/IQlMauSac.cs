using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQlMauSac
    {
        bool Add(ViewMauSac obj);
        bool Update(ViewMauSac obj);
        bool Delete(ViewMauSac obj);
        List<ViewMauSac> GetAll();
    }
}
