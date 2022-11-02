using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLNSX : IQLNSX
    {
        private INsxRepos _iNsxRepos;
        public QLNSX()
        {
            _iNsxRepos = new NsxRepos();
        }
        public bool Add(ViewNSX obj)
        {
            var vnsx = new Nsx()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            _iNsxRepos.Add(vnsx);
            return true;
        }

        public bool Delete(ViewNSX obj)
        {
            var vnsx = new Nsx()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            _iNsxRepos.Delete(vnsx);
            return true;
        }

        public List<ViewNSX> GetAll()
        {
            List<ViewNSX> _lstNSX = new List<ViewNSX>();
            _lstNSX = (
                from a in _iNsxRepos.GetAll()
                select new ViewNSX()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                }).ToList();
            return _lstNSX;
        }

        public bool Update(ViewNSX obj)
        {
            var vnsx = new Nsx()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            _iNsxRepos.Update(vnsx);
            return true;
        }
    }
}
