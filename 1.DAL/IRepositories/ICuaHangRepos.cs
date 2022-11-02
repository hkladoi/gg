using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.IRepositories
{
    public interface ICuaHangRepos
    {
        bool Add(CuaHang obj);
        bool Update(CuaHang obj);
        bool Delete(CuaHang obj);
        CuaHang GetByID(Guid id);
        List<CuaHang> GetAll();
    }
}
