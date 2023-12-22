using Core.Utilities.Results.Abstract;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IResult AddRental(Rental rental);

        IResult DeleteRental(Rental rental);

        IResult UpdateRental(Rental rental);

        IDataResult<Rental> getById(int rentalId);

        IDataResult<List<RentalDetailDto>> GetRentalDetails();

        IDataResult<Rental> CheckRentalCarId(int carId);


    }
}
