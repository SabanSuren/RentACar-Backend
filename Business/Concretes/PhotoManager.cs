using Business.Abstracts;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class PhotoManager : IPhotoService
    {

        IPhotoDal _photoDal;
        IFileHelper _fileHelper;


        public PhotoManager(IPhotoDal photoDal, IFileHelper fileHelper)
        {
            _photoDal = photoDal;   
            _fileHelper = fileHelper;
        }

        [ValidationAspect(typeof(PhotoValidator))]
        public IResult Add(IFormFile file, Photo photo)
        {
            IResult result = BusinessRules.Run();
            if (result == null)
            {
                return result;
            }
            photo.ImagePath = _fileHelper.Upload(file, PathConstants.ImagePath);
            photo.Date = DateTime.Now;
            _photoDal.Add(photo);

            return new SuccessResult(Messages.PhotoAdded);
        }

        public IResult Delete(Photo photo)
        {
            _fileHelper.Delete(PathConstants.ImagePath+photo.ImagePath);
            _photoDal.Delete(photo);
            return new SuccessResult(Messages.PhotoDeleted);
        }

        public IDataResult<List<Photo>> GetAll()
        {
           return new SuccessDataResult<List<Photo>>(_photoDal.GetAll());
        }

        public IDataResult<List<Photo>> GetAllByCarId(int id)
        {
            return new SuccessDataResult<List<Photo>>(_photoDal.GetAll());
        }

        public IResult Update(IFormFile file, Photo photo)
        {
            photo.ImagePath = _fileHelper.Update(file, PathConstants.ImagePath + photo.ImagePath, PathConstants.ImagePath);

            _photoDal.Update(photo);

            return new SuccessResult(Messages.Update);
        }
    }
}
