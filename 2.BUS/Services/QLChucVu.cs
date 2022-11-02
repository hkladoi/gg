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
    public class QLChucVu : IQLChucVu
    {
        private IChucVuRepos _iChucVuRepos;
        public QLChucVu()
        {
            _iChucVuRepos = new ChucVuRepos();
        }
        public string Add(ViewChucVu obj)
        {
            var cv = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            _iChucVuRepos.Add(cv);
            return "thành công";
        }

        public string Delete(ViewChucVu obj)
        {
            var cv = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            _iChucVuRepos.Delete(cv);
            return "thành công";
        }

        public List<ViewChucVu> GetAll()
        {
            List<ViewChucVu> _lstChucVu = new List<ViewChucVu>();
            _lstChucVu = (from a in _iChucVuRepos.GetAll()
                          select new ViewChucVu()
                          {
                              Id = a.Id,
                              Ma = a.Ma,
                              Ten = a.Ten,
                              Des = a.Ma.StartsWith("C") ? "giám đốc" : "nhân viên"
                          }).ToList();
            return _lstChucVu;
        }

        public ChucVu GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(ViewChucVu obj)
        {
            var cv = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            _iChucVuRepos.Update(cv);
            return "thành công";
        }
    }
}
