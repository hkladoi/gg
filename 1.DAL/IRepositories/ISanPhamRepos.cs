﻿using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ISanPhamRepos
    {
        bool Add(SanPham obj);
        bool Update(SanPham obj);
        bool Delete(SanPham obj);
        SanPham GetByID(Guid id);
        List<SanPham> GetAll();
    }
}
