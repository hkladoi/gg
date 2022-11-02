using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _1.DAL.IRepositories
{
    public interface IDongSpRepos
    {
        bool Add(DongSp obj);
        bool Update(DongSp obj);
        bool Delete(DongSp obj);
        DongSp GetByID(Guid id);
        List<DongSp> GetAll();
    }
}
