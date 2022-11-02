using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonRepos
    {
        bool Add(HoaDon obj);
        bool Update(HoaDon obj);
        bool Delete(HoaDon obj);
        HoaDon GetByID(Guid id);
        List<HoaDon> GetAll();
    }
}
