using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, CarSaleContext>, IBrandDal
    {
        
    }
}
