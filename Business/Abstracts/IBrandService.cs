using Core.Utilities.Results.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IBrandService
    {
        IResult AddBrand(Brand brand);

        IResult DeleteBrand(Brand brand);

        IResult UpdateBrand(Brand brand);

        IDataResult<Brand> GetById(int BrandId);
        IDataResult<List<Brand>> GetAll();
    }
}
