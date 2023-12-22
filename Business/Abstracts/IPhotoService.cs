using Core.Utilities.Results.Abstract;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IPhotoService
    {
        IDataResult<List<Photo>> GetAll();

        IDataResult<List<Photo>> GetAllByCarId(int id);

        IResult Add(IFormFile file, Photo photo);

     

        IResult Delete(Photo photo);

        IResult Update(IFormFile file, Photo photo);
    }
}
