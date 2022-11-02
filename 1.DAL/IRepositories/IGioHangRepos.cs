using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.IRepositories
{
    public interface IGioHangRepos
    {
        bool Add(GioHang obj);
        bool Update(GioHang obj);
        bool Delete(GioHang obj);
        GioHang GetByID(Guid id);
        List<GioHang> GetAll();
    }
}
