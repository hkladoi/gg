using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.IRepositories
{
    public interface IChiTietSPRepos
    {
        bool Add(ChiTietSp obj);
        bool Update(ChiTietSp obj);
        bool Delete(ChiTietSp obj);
        ChiTietSp GetByID(Guid id);
        List<ChiTietSp> GetAll();
    }
}
