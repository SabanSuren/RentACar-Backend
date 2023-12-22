using Business.Abstracts;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class RentalManager : IRentalService
    {
      
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal )
        {
           
            _rentalDal = rentalDal;
 
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult AddRental(Rental rental)
        {
            IResult result = BusinessRules.Run(/*CheckIfRentalEndDateNotEntered(rental)*/);
            if (result != null)
            {
                return result;
            }
            _rentalDal.Add(rental);

            return new SuccessResult(Messages.Addet);
            
        }
        public IResult DeleteRental(Rental rental)
        {
            _rentalDal.Delete(rental);

            return new SuccessResult(Messages.Delete);
        }

        public IDataResult<List<Rental>> GetAll()
        {
           return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> getById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.RentalId==rentalId));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
          
           return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult UpdateRental(Rental rental)
        {
            _rentalDal.Update(rental);

            return new SuccessResult(Messages.Update);
        }

        public IDataResult<Rental> CheckRentalCarId(int carId)
        {
            var rental = _rentalDal.Get(r => r.CarId == carId && r.ReturnDate == null);
            if (rental != null)
            {
                return new ErrorDataResult<Rental>("Araç müsait değil, kiralanmış durumda");
            }
            return new SuccessDataResult<Rental>("Araç müsait, kiralanabilir durumda");
        }

        //private IResult CheckIfRentalEndDateNotEntered(Rental rental)
        //{
        //    if (rental.ReturnDate == null)
        //    {
        //        // Dönüş tarihi girilmemişse, veritabanına null olarak işaretlenir.
        //        rental.ReturnDate = null; // Eğer zaten null ise bu satırı eklemenize gerek yok.

        //        // Burada gerekirse başka kontroller de yapabilir ve farklı hata mesajları döndürebilirsiniz.

        //        // Veritabanına güncellenmiş Rental nesnesini kaydetme işlemi gerçekleştirilir.
        //        _rentalService.UpdateRental(rental);

        //        return new SuccessResult(Messages.RentalEndDateNotEntered);
        //    }

        //    return new SuccessResult();
        //}

    }
}
