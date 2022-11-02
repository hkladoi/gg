using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class QLMauSac : IQlMauSac
    {
        private IMauSacRepos _iMauSacRepos;
        public QLMauSac()
        {
            _iMauSacRepos = new MauSacRepos();
        }

        public bool Add(ViewMauSac obj)
        {
            var vms = new MauSac()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            _iMauSacRepos.Add(vms);
            return true;
        }

        public bool Delete(ViewMauSac obj)
        {
            var vms = new MauSac()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            _iMauSacRepos.Delete(vms);
            return true;
        }

        public List<ViewMauSac> GetAll()
        {
            List<ViewMauSac> _lstMauSac = new List<ViewMauSac>();
            _lstMauSac = (
                from a in _iMauSacRepos.GetAll()
                select new ViewMauSac()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                }).ToList();
            return _lstMauSac;
        }

        public bool Update(ViewMauSac obj)
        {
            var vms = new MauSac()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            _iMauSacRepos.Update(vms);
            return true;
        }
    }
}
