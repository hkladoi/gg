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
    public class MauSacRepos : IMauSacRepos
    {
        FpolyDBContext _dBContext;
        public MauSacRepos()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(MauSac obj)
        {
            if (obj == null) return false;
            _dBContext.MauSacs.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(MauSac obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.MauSacs.FirstOrDefault(x => x.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<MauSac> GetAll()
        {
            return _dBContext.MauSacs.ToList();
        }

        public MauSac GetByID(Guid id)
        {

            if (id == Guid.Empty) return null;
            return _dBContext.MauSacs.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(MauSac obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.MauSacs.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            _dBContext.MauSacs.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
