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
    public class QLDongSP : IQLDongSp
    {
        private IDongSpRepos _iDongSpRepo;
        public QLDongSP()
        {
            _iDongSpRepo = new DongSpRepos();
        }

        public bool Add(ViewDongSP obj)
        {
            var vdsp = new DongSp()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            _iDongSpRepo.Add(vdsp);
            return true;
        }

        public bool Delete(ViewDongSP obj)
        {
            var vdsp = new DongSp()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            _iDongSpRepo.Delete(vdsp);
            return true;
        }

        public List<ViewDongSP> GetAll()
        {
            List<ViewDongSP> _lstDongSp = new List<ViewDongSP>();
            _lstDongSp = (
                from a in _iDongSpRepo.GetAll()
                select new ViewDongSP()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                }).ToList();
            return _lstDongSp;
        }

        public bool Update(ViewDongSP obj)
        {
            var vdsp = new DongSp()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            _iDongSpRepo.Update(vdsp);
            return true;
        }
    }
}
