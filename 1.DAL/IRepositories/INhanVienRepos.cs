using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.IRepositories
{
    public interface INhanVienRepos
    {
        bool Add(NhanVien obj);
        bool Update(NhanVien obj);
        bool Delete(NhanVien obj);
        NhanVien GetByID(Guid id);
        List<NhanVien> GetAll();
    }
}
