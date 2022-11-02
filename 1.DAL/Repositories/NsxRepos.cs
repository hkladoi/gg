using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class NsxRepos : INsxRepos
    {
        FpolyDBContext _dBContext;
        public NsxRepos()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(Nsx obj)
        {
            if (obj == null) return false;
            _dBContext.Nsxes.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(Nsx obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<Nsx> GetAll()
        {
            return _dBContext.Nsxes.ToList();
        }

        public Nsx GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.Nsxes.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(Nsx obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ten = obj.Ten;
            tempobj.Ma = obj.Ma;
            _dBContext.Nsxes.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
