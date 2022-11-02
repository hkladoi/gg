using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.IRepositories
{
    public interface IKhachHangRepos
    {
        bool Add(KhachHang obj);
        bool Update(KhachHang obj);
        bool Delete(KhachHang obj);
        KhachHang GetByID(Guid id);
        List<KhachHang> GetAll();
    }
}
